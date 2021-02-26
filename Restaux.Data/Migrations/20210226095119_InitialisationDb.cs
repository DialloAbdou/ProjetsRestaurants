using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaux.Data.Migrations
{
    public partial class InitialisationDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //========Utilisateurs========;
            migrationBuilder.Sql("INSERT INTO Utilisateurs(Prenom,MotDePasse) Values('Abdou', 'Toto')");
            migrationBuilder.Sql("INSERT INTO Utilisateurs(Prenom,MotDePasse) Values('David', 'Titi')");
            migrationBuilder.Sql("INSERT INTO Utilisateurs(Prenom,MotDePasse) Values('Antony', 'Lolo')");
            migrationBuilder.Sql("INSERT INTO Utilisateurs(Prenom,MotDePasse) Values('Aminata', 'Mimi')");
            migrationBuilder.Sql("INSERT INTO Utilisateurs(Prenom,MotDePasse) Values('Adama', 'Juju')");
            migrationBuilder.Sql("INSERT INTO Utilisateurs(Prenom,MotDePasse) Values('Fatou', 'Coco')");

            // ====Restaurant======
            migrationBuilder.Sql("INSERT INTO Restos(Nom,Telephone) Values('Petit Plat','0416257893')");
            migrationBuilder.Sql("INSERT INTO Restos(Nom,Telephone) Values('Grande Marmite','052482350')");
            migrationBuilder.Sql("INSERT INTO Restos(Nom,Telephone) Values('Pizza Plaza','0416257893')");
            migrationBuilder.Sql("INSERT INTO Restos(Nom,Telephone) Values('Petit Cocotier','0316504883')");

            //====Sondage===
            






        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder
               .Sql("DELETE FROM Votes");
            migrationBuilder
            .Sql("DELETE FROM Sondages");

            migrationBuilder
           .Sql("DELETE FROM Utilisateurs");
            migrationBuilder
                .Sql("DELETE FROM Restos");
        }
    }
}
