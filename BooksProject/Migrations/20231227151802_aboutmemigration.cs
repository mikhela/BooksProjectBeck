using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BooksProject.Migrations
{
    public partial class aboutmemigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "aboutme",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    aboutmyself = table.Column<string>(type: "nvarchar(1500)", maxLength: 1500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aboutme", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "aboutme",
                columns: new[] { "Id", "Name", "Surname", "aboutmyself" },
                values: new object[] { 1, "გიორგი", "ომანაძე", "მე ვარ გიორგი ომანაძე junior developer, ჩემი ამბავი დაიწყო ჯერ კიდევ ღმა ბავშვობის დროიდან, მე მიზიდავდა ტექნოლოგიები, კომპიუტერები, კომპიუტერული თამაშები. ზუსტად თამაშების სიყვარულმა მიმიყვანა ამ დონემდე. ჩემი ყოველდღიური ცხოვრება თამაშებიდან პროგრამირებამდე ვაქციე. მე შევისწავლე და ვცდილობ საუკეთესო დონეზე დავეუფლო სხვადასხვა ენებს HTML, CSS, JS, C#. ვცდილობ ჩარჩოებს გაცდეს ჩემი ცოდნა და გავაუნჯობესო ჩემი გამოცდილება. ვაფასებ გუნდურ მუშაობას, კომუნიკაციას და თანამშრომლობით პროცესს. ჩვენ შეგვიძლია ვითანამშრომლოთ და შევქმნათ შესანიშნავი პროექტი." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "aboutme");
        }
    }
}
