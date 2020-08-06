import { StudentDto } from "./student-dto";

export class StudentDtoPagedResultDto implements IStudentPagedResultDto {
    totalCount: number;
    items: StudentDto[] | undefined;

    constructor(data?: IStudentPagedResultDto) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(data?: any) {
        if (data) {
            this.totalCount = data["totalCount"];
            if (Array.isArray(data["items"])) {
                this.items = [] as any;
                for (let item of data["items"])
                    this.items.push(StudentDto.fromJS(item));
            }
        }
    }

    static fromJS(data: any): StudentDtoPagedResultDto {
        data = typeof data === 'object' ? data : {};
        let result = new StudentDtoPagedResultDto();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["totalCount"] = this.totalCount;
        if (Array.isArray(this.items)) {
            data["items"] = [];
            for (let item of this.items)
                data["items"].push(item.toJSON());
        }
        return data;
    }

    clone(): StudentDtoPagedResultDto {
        const json = this.toJSON();
        let result = new StudentDtoPagedResultDto();
        result.init(json);
        return result;
    }
}

export interface IStudentPagedResultDto {
    totalCount: number;
    items: StudentDto[] | undefined;
}