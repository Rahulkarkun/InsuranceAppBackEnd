using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InsuranceApp.Migrations
{
    /// <inheritdoc />
    public partial class v6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InsurancePolicies_InsurancePlans_PlanId",
                table: "InsurancePolicies");

            migrationBuilder.DropForeignKey(
                name: "FK_InsurancePolicies_InsuranceSchemes_InsuranceSchemeSchemeId",
                table: "InsurancePolicies");

            migrationBuilder.DropForeignKey(
                name: "FK_InsuranceSchemes_SchemeDetails_DetailId",
                table: "InsuranceSchemes");

            migrationBuilder.DropIndex(
                name: "IX_InsuranceSchemes_DetailId",
                table: "InsuranceSchemes");

            migrationBuilder.DropIndex(
                name: "IX_InsurancePolicies_InsuranceSchemeSchemeId",
                table: "InsurancePolicies");

            migrationBuilder.DropIndex(
                name: "IX_InsurancePolicies_PlanId",
                table: "InsurancePolicies");

            migrationBuilder.DropColumn(
                name: "DetailId",
                table: "InsuranceSchemes");

            migrationBuilder.DropColumn(
                name: "InsuranceSchemeSchemeId",
                table: "InsurancePolicies");

            migrationBuilder.RenameColumn(
                name: "PlanId",
                table: "InsurancePolicies",
                newName: "SchemeId");

            migrationBuilder.AddColumn<int>(
                name: "SchemeId",
                table: "SchemeDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SchemeDetails_SchemeId",
                table: "SchemeDetails",
                column: "SchemeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_InsurancePolicies_SchemeId",
                table: "InsurancePolicies",
                column: "SchemeId");

            migrationBuilder.AddForeignKey(
                name: "FK_InsurancePolicies_InsuranceSchemes_SchemeId",
                table: "InsurancePolicies",
                column: "SchemeId",
                principalTable: "InsuranceSchemes",
                principalColumn: "SchemeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SchemeDetails_InsuranceSchemes_SchemeId",
                table: "SchemeDetails",
                column: "SchemeId",
                principalTable: "InsuranceSchemes",
                principalColumn: "SchemeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InsurancePolicies_InsuranceSchemes_SchemeId",
                table: "InsurancePolicies");

            migrationBuilder.DropForeignKey(
                name: "FK_SchemeDetails_InsuranceSchemes_SchemeId",
                table: "SchemeDetails");

            migrationBuilder.DropIndex(
                name: "IX_SchemeDetails_SchemeId",
                table: "SchemeDetails");

            migrationBuilder.DropIndex(
                name: "IX_InsurancePolicies_SchemeId",
                table: "InsurancePolicies");

            migrationBuilder.DropColumn(
                name: "SchemeId",
                table: "SchemeDetails");

            migrationBuilder.RenameColumn(
                name: "SchemeId",
                table: "InsurancePolicies",
                newName: "PlanId");

            migrationBuilder.AddColumn<int>(
                name: "DetailId",
                table: "InsuranceSchemes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InsuranceSchemeSchemeId",
                table: "InsurancePolicies",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_InsuranceSchemes_DetailId",
                table: "InsuranceSchemes",
                column: "DetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_InsurancePolicies_InsuranceSchemeSchemeId",
                table: "InsurancePolicies",
                column: "InsuranceSchemeSchemeId");

            migrationBuilder.CreateIndex(
                name: "IX_InsurancePolicies_PlanId",
                table: "InsurancePolicies",
                column: "PlanId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_InsurancePolicies_InsurancePlans_PlanId",
                table: "InsurancePolicies",
                column: "PlanId",
                principalTable: "InsurancePlans",
                principalColumn: "PlanId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InsurancePolicies_InsuranceSchemes_InsuranceSchemeSchemeId",
                table: "InsurancePolicies",
                column: "InsuranceSchemeSchemeId",
                principalTable: "InsuranceSchemes",
                principalColumn: "SchemeId");

            migrationBuilder.AddForeignKey(
                name: "FK_InsuranceSchemes_SchemeDetails_DetailId",
                table: "InsuranceSchemes",
                column: "DetailId",
                principalTable: "SchemeDetails",
                principalColumn: "DetailId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
