namespace DA.ProjectManagement.Authorization
{
    public static class PermissionNames
    {
        public const string Pages_Tenants = "Pages.Tenants";

        public const string Pages_Users = "Pages.Users";

        public const string Pages_Roles = "Pages.Roles";
    }

    public static class StudentPermission
    {
        public const string Student = "Administration.StudentManagement";
        public const string Default = Student + ".Default";
        public const string Create = Student + ".Create";
        public const string Update = Student + ".Update";
        public const string Delete = Student + ".Delete";
    }

    public static class TeacherPermission
    {
        public const string Teacher = "Teacher";
        public const string Default = Teacher + ".Default";
        public const string Create = Teacher + ".Create";
        public const string Update = Teacher + ".Update";
        public const string Delete = Teacher + ".Delete";
    }
}
