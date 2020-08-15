export class StudentDto implements IStudentDto {

    name: string | undefined;
    birthday: Date | undefined;
    phoneNumber: string | undefined;
    email: string | undefined;
    address: string;
    courseYear: string;
    studentCode: string;
    faculty: string | undefined;
    branch: string | undefined;
    id: string;

    constructor(data?: IStudentDto) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(data?: any) {
        if (data) {
            this.name = data["name"];
            this.birthday = data["birthday"];
            this.phoneNumber = data["phoneNumber"];
            this.email = data["email"];
            this.address = data["address"];
            this.courseYear = data["courseYear"];
            this.studentCode = data["studentCode"];
            this.faculty = data["facutly"];
            this.branch = data["branch"];
            this.id = data["id"];
        }
    }

    static fromJS(data: any): StudentDto {
        data = typeof data === 'object' ? data : {};
        let result = new StudentDto();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["name"] = this.name;
        data["birthday"] = this.birthday;
        data["phoneNumber"] = this.phoneNumber;
        data["email"] = this.email;
        data["address"] = this.address;
        data["courseYear"] = this.courseYear;
        data["StudentCode"] = this.studentCode;
        data["faculty"] = this.faculty;
        data["branch"] = this.branch;
        data["id"] = this.id;
        return data;
    }

    clone(): StudentDto {
        const json = this.toJSON();
        let result = new StudentDto();
        result.init(json);
        return result;
    }
}

export interface IStudentDto {
    name: string | undefined;
    birthday: Date | undefined;
    phoneNumber: string | undefined;
    email: string | undefined;
    address: string;
    courseYear: string;
    studentCode: string;
    faculty: string | undefined;
    branch: string | undefined;
    id: string;
}
