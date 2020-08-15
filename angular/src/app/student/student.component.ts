import { Component, Injector } from '@angular/core';
import {
    PagedListingComponentBase,
    PagedRequestDto,
} from '../shared/paged-listing-component-base';
import { StudentDto } from '../shared/service-proxies/service/modules/student-dto';
import { StudentService } from '../shared/service-proxies/service-proxies';
import { finalize } from 'rxjs/operators';
import { StudentDtoPagedResultDto } from '../shared/service-proxies/service/modules/student-dto-paged-result-dto';
import { BsModalService, BsModalRef } from 'ngx-bootstrap/modal';
import { CreateStudentDialogComponent } from './create/create-student.component';
import { EditStudentDialogComponent } from './edit/edit-student.component';

class PagedStudentRequestDto extends PagedRequestDto {
    keyword: string;
    isActive: boolean | null;
}

declare var abp;
@Component({
    templateUrl: 'student.component.html',
})

export class StudentComponent extends PagedListingComponentBase<StudentDto> {


    students: StudentDto[];
    keyword = "";
    isActive: boolean | undefined;
    advanceFilterVisiable = false;
    constructor(injector: Injector,
        private _studentService: StudentService,
        private _modalService: BsModalService) {
        super(injector);
    }

    list(request: PagedStudentRequestDto, pageNumber: number, finishedCallback: Function): void {
        request.keyword = this.keyword;
        request.isActive = this.isActive;

        this._studentService.getAll(request.keyword, request.skipCount, request.maxResultCount)
            .pipe(finalize(() => {
                finishedCallback();
            })).subscribe((result: StudentDtoPagedResultDto) => {
                this.students = result.items;
                this.showPaging(result, pageNumber);
            })

    }
    protected delete(entity: StudentDto): void {
        abp.message.confirm(
            this.l('TenantDeleteWarningMessage', entity.name),
            undefined,
            (result: boolean) => {
                if (result) {
                    this._studentService
                        .delete(entity.id)
                        .pipe(
                            finalize(() => {
                                abp.notify.success(this.l('SuccessfullyDeleted'));
                                this.refresh();
                            })
                        )
                        .subscribe(() => { });
                }
            }
        );
    }

    createStudent() {
        this.showCreateOrEditStudent();
    }

    editStudent(id: string) {
        this.showCreateOrEditStudent(id);

    }

    showCreateOrEditStudent(id?: string) {
        let CreateOrEditStudentDialog: BsModalRef;
        if (!id) {
            CreateOrEditStudentDialog = this._modalService.show(
                CreateStudentDialogComponent,
                {
                    class: 'modal-lg',
                }
            );
        } else {
            CreateOrEditStudentDialog = this._modalService.show(
                EditStudentDialogComponent,
                {
                    class: 'modal-lg',
                    initialState: {
                        id: id,
                    }
                }
            );
        }
        CreateOrEditStudentDialog.content.onSave.subscribe(() => {
            this.refresh();
        })
    }

    createFilter(): void {
        this.keyword = "";
        this.getDataPage(1);
    }

}