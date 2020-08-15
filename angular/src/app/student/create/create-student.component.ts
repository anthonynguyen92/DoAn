import { Component, OnInit, Injector, Output, EventEmitter } from '@angular/core';
import { AppComponentBase } from '../../shared/app-component-base';
import { StudentDto } from '@app/shared/service-proxies/service/modules/student-dto';
import { StudentService } from '@app/shared/service-proxies/service-proxies';
import { __setInputValues } from '@angularclass/hmr';
import { finalize } from 'rxjs/operators';
import { BsModalRef } from 'ngx-bootstrap/modal';

@Component({
    templateUrl: './create-student.component.html'
})

export class CreateStudentDialogComponent extends AppComponentBase implements OnInit {
    saving = false;
    student: StudentDto = new StudentDto();

    @Output() onSave = new EventEmitter();
    constructor(injector: Injector,
        public _studentService: StudentService,
        public _bsModalRef: BsModalRef) {
        super(injector)
    }

    ngOnInit() { }

    save() {
        this.saving = true;
        this.student.birthday = new Date();
        this._studentService.createStudent(this.student).pipe(
            finalize(() => {
                this.saving = false;
            })
        ).subscribe(() => {
            this.notify.success('SavedSuccessfully');
            this._bsModalRef.hide();
            this.onSave.emit();
        })
    }
}
