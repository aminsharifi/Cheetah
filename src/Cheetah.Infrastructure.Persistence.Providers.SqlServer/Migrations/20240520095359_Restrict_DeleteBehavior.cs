using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah.Infrastructure.Persistence.Providers.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class Restrict_DeleteBehavior : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_D_Tag_D_TagCategory_TagCategoryId",
                schema: "Dimentions",
                table: "D_Tag");

            migrationBuilder.DropForeignKey(
                name: "FK_D_Tag_D_TagType_TagTypeId",
                schema: "Dimentions",
                table: "D_Tag");

            migrationBuilder.DropForeignKey(
                name: "FK_D_User_D_User_DelegateId",
                schema: "Dimentions",
                table: "D_User");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Case_D_CaseState_CaseStateId",
                schema: "Facts",
                table: "F_Case");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Case_D_Process_ProcessId",
                schema: "Facts",
                table: "F_Case");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Case_D_User_CreatorId",
                schema: "Facts",
                table: "F_Case");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Case_D_User_RequestorId",
                schema: "Facts",
                table: "F_Case");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Case_F_Scenario_SelectedScenarioId",
                schema: "Facts",
                table: "F_Case");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Condition_D_Operand_OperandId",
                schema: "Facts",
                table: "F_Condition");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Condition_D_Tag_TagId",
                schema: "Facts",
                table: "F_Condition");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Task_F_Scenario_ScenarioId",
                schema: "Facts",
                table: "F_Task");

            migrationBuilder.DropForeignKey(
                name: "FK_F_WorkItem_D_User_UserId",
                schema: "Facts",
                table: "F_WorkItem");

            migrationBuilder.DropForeignKey(
                name: "FK_F_WorkItem_D_WorkItemState_WorkItemStateId",
                schema: "Facts",
                table: "F_WorkItem");

            migrationBuilder.DropForeignKey(
                name: "FK_F_WorkItem_F_Case_CaseId",
                schema: "Facts",
                table: "F_WorkItem");

            migrationBuilder.DropForeignKey(
                name: "FK_F_WorkItem_F_Task_TaskId",
                schema: "Facts",
                table: "F_WorkItem");

            migrationBuilder.DropForeignKey(
                name: "FK_L_CaseCondition_F_Case_FirstId",
                schema: "Links",
                table: "L_CaseCondition");

            migrationBuilder.DropForeignKey(
                name: "FK_L_CaseCondition_F_Condition_SecondId",
                schema: "Links",
                table: "L_CaseCondition");

            migrationBuilder.DropForeignKey(
                name: "FK_L_CaseTaskUser_D_User_ThirdId",
                schema: "Links",
                table: "L_CaseTaskUser");

            migrationBuilder.DropForeignKey(
                name: "FK_L_CaseTaskUser_F_Case_FirstId",
                schema: "Links",
                table: "L_CaseTaskUser");

            migrationBuilder.DropForeignKey(
                name: "FK_L_CaseTaskUser_F_Task_SecondId",
                schema: "Links",
                table: "L_CaseTaskUser");

            migrationBuilder.DropForeignKey(
                name: "FK_L_FlowCondition_F_Condition_SecondId",
                schema: "Links",
                table: "L_FlowCondition");

            migrationBuilder.DropForeignKey(
                name: "FK_L_FlowCondition_F_Flow_FirstId",
                schema: "Links",
                table: "L_FlowCondition");

            migrationBuilder.DropForeignKey(
                name: "FK_L_FlowTask_F_Flow_FirstId",
                schema: "Links",
                table: "L_FlowTask");

            migrationBuilder.DropForeignKey(
                name: "FK_L_FlowTask_F_Task_SecondId",
                schema: "Links",
                table: "L_FlowTask");

            migrationBuilder.DropForeignKey(
                name: "FK_L_ProcessScenario_D_Process_FirstId",
                schema: "Links",
                table: "L_ProcessScenario");

            migrationBuilder.DropForeignKey(
                name: "FK_L_ProcessScenario_F_Scenario_SecondId",
                schema: "Links",
                table: "L_ProcessScenario");

            migrationBuilder.DropForeignKey(
                name: "FK_L_ScenarioCondition_F_Condition_SecondId",
                schema: "Links",
                table: "L_ScenarioCondition");

            migrationBuilder.DropForeignKey(
                name: "FK_L_ScenarioCondition_F_Scenario_FirstId",
                schema: "Links",
                table: "L_ScenarioCondition");

            migrationBuilder.DropForeignKey(
                name: "FK_L_TaskCondition_F_Condition_SecondId",
                schema: "Links",
                table: "L_TaskCondition");

            migrationBuilder.DropForeignKey(
                name: "FK_L_TaskCondition_F_Task_FirstId",
                schema: "Links",
                table: "L_TaskCondition");

            migrationBuilder.DropForeignKey(
                name: "FK_L_TaskFlow_F_Flow_SecondId",
                schema: "Links",
                table: "L_TaskFlow");

            migrationBuilder.DropForeignKey(
                name: "FK_L_TaskFlow_F_Task_FirstId",
                schema: "Links",
                table: "L_TaskFlow");

            migrationBuilder.DropForeignKey(
                name: "FK_L_UserCondition_D_User_FirstId",
                schema: "Links",
                table: "L_UserCondition");

            migrationBuilder.DropForeignKey(
                name: "FK_L_UserCondition_F_Condition_SecondId",
                schema: "Links",
                table: "L_UserCondition");

            migrationBuilder.DropForeignKey(
                name: "FK_L_WorkItemCondition_F_Condition_SecondId",
                schema: "Links",
                table: "L_WorkItemCondition");

            migrationBuilder.DropForeignKey(
                name: "FK_L_WorkItemCondition_F_WorkItem_FirstId",
                schema: "Links",
                table: "L_WorkItemCondition");

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 894, DateTimeKind.Unspecified).AddTicks(8042), new TimeSpan(0, 3, 30, 0, 0)), new Guid("58e017aa-2cac-40cf-89bd-1e47004d54f8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 894, DateTimeKind.Unspecified).AddTicks(8054), new TimeSpan(0, 3, 30, 0, 0)), new Guid("230ee93b-0389-492c-b3c4-2ad61408da7b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 895, DateTimeKind.Unspecified).AddTicks(839), new TimeSpan(0, 3, 30, 0, 0)), new Guid("998ec1c9-a1db-44b0-83f2-ea0aa780ec04") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 895, DateTimeKind.Unspecified).AddTicks(852), new TimeSpan(0, 3, 30, 0, 0)), new Guid("72216169-6a03-4076-b7a6-bfd6848f3815") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 895, DateTimeKind.Unspecified).AddTicks(864), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ce63b821-aa66-463d-96f2-5cf06074ef2f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 895, DateTimeKind.Unspecified).AddTicks(866), new TimeSpan(0, 3, 30, 0, 0)), new Guid("155aa2dc-d2a3-48e8-a996-ce343244729d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 897, DateTimeKind.Unspecified).AddTicks(2244), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7381ced7-ca12-4e40-9c79-c67a14ab184b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 898, DateTimeKind.Unspecified).AddTicks(8773), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cd607075-820f-4c13-b0f9-efb98b71c5c2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 898, DateTimeKind.Unspecified).AddTicks(8807), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c37ef5c6-a163-45c1-be08-8275bc43b2e6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 898, DateTimeKind.Unspecified).AddTicks(8815), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1265b8f6-fb58-43b3-b2f7-51d44b17fc22") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 898, DateTimeKind.Unspecified).AddTicks(8822), new TimeSpan(0, 3, 30, 0, 0)), new Guid("432ec273-3e16-4728-a13a-f2d947820ab1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 898, DateTimeKind.Unspecified).AddTicks(8858), new TimeSpan(0, 3, 30, 0, 0)), new Guid("583cb8a1-804e-4d85-8129-d233ecf4f118") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 898, DateTimeKind.Unspecified).AddTicks(8865), new TimeSpan(0, 3, 30, 0, 0)), new Guid("66cb6f56-7541-4fa6-9cac-6936eb6582e2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 898, DateTimeKind.Unspecified).AddTicks(8881), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a728bfaa-a798-48be-a0f3-5510e4efba84") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 898, DateTimeKind.Unspecified).AddTicks(8895), new TimeSpan(0, 3, 30, 0, 0)), new Guid("708c7c9e-d33a-47fe-9f63-69091424455a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 898, DateTimeKind.Unspecified).AddTicks(8901), new TimeSpan(0, 3, 30, 0, 0)), new Guid("05d6000a-54c9-4e72-aa58-7a6d5a572847") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 898, DateTimeKind.Unspecified).AddTicks(8907), new TimeSpan(0, 3, 30, 0, 0)), new Guid("60a04b16-39b4-44b0-a8f1-47a238376be3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 898, DateTimeKind.Unspecified).AddTicks(8913), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8f9a03fb-6424-4529-8cfd-4c46d47bc2ff") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 898, DateTimeKind.Unspecified).AddTicks(8918), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cd2bdd79-850e-4ec2-adb3-80e5d69a212c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 898, DateTimeKind.Unspecified).AddTicks(8923), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1638068b-cf07-4de2-af67-387587c1c0f0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 894, DateTimeKind.Unspecified).AddTicks(1221), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9a9e9ec7-a04f-419c-bd24-c943aaab8db7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 894, DateTimeKind.Unspecified).AddTicks(1232), new TimeSpan(0, 3, 30, 0, 0)), new Guid("de531e42-8a33-4721-bb9e-580d0cb10a5d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 894, DateTimeKind.Unspecified).AddTicks(1234), new TimeSpan(0, 3, 30, 0, 0)), new Guid("eff4d685-6598-42b1-8097-db6b86f4264e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 894, DateTimeKind.Unspecified).AddTicks(1237), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3491bef9-bbb8-4ac3-9288-ec85e30c5499") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 894, DateTimeKind.Unspecified).AddTicks(1239), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3415cff6-f21e-4f59-9731-51bfa03e92a4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 894, DateTimeKind.Unspecified).AddTicks(1241), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b9083c5c-65ff-485c-88c3-2e0927dc7398") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 891, DateTimeKind.Unspecified).AddTicks(9952), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3d709c21-3260-413d-b5db-6fb7864ed6b6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 893, DateTimeKind.Unspecified).AddTicks(5126), new TimeSpan(0, 3, 30, 0, 0)), new Guid("bc1ec724-ce16-4fc8-b439-1fb0a2b03773") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 893, DateTimeKind.Unspecified).AddTicks(7295), new TimeSpan(0, 3, 30, 0, 0)), new Guid("61c1fdcc-c06a-4510-8901-b6523fc048d9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 893, DateTimeKind.Unspecified).AddTicks(7337), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f77cc4c7-501f-45fd-9af9-c2902a1dfd46") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 893, DateTimeKind.Unspecified).AddTicks(7341), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a9e52c96-274a-4618-a3d3-10ba5c896efa") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 893, DateTimeKind.Unspecified).AddTicks(7344), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0c41c578-718b-4994-91cd-6ac3f2b31f00") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 893, DateTimeKind.Unspecified).AddTicks(7348), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f0cb4144-b05b-45f5-8c6b-26f7982dcb76") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 893, DateTimeKind.Unspecified).AddTicks(7354), new TimeSpan(0, 3, 30, 0, 0)), new Guid("90c62506-c7a1-46e5-b281-3f1ec068ba8e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 893, DateTimeKind.Unspecified).AddTicks(7182), new TimeSpan(0, 3, 30, 0, 0)), new Guid("40a2d399-c3a8-46f0-8201-a08cbcee7237") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 893, DateTimeKind.Unspecified).AddTicks(7186), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e18585f4-3824-421d-8fab-e116b46e8fa2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 893, DateTimeKind.Unspecified).AddTicks(6170), new TimeSpan(0, 3, 30, 0, 0)), new Guid("42cc5f08-bff4-4832-a873-4ccc349b2335") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 893, DateTimeKind.Unspecified).AddTicks(6176), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b90b68f3-1711-4664-bf6b-8725fbb32cc9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 893, DateTimeKind.Unspecified).AddTicks(6179), new TimeSpan(0, 3, 30, 0, 0)), new Guid("dc8c9802-9711-4e27-8363-b54589d8ad44") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 893, DateTimeKind.Unspecified).AddTicks(6195), new TimeSpan(0, 3, 30, 0, 0)), new Guid("18a8d29f-bec9-4525-ac90-6a1e4da97859") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 896, DateTimeKind.Unspecified).AddTicks(2055), new TimeSpan(0, 3, 30, 0, 0)), new Guid("142a3fab-6d3e-455c-92e6-8f6200000282") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 896, DateTimeKind.Unspecified).AddTicks(2088), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3399b1e7-f35d-4912-a6a2-adc41e03d57c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 895, DateTimeKind.Unspecified).AddTicks(3458), new TimeSpan(0, 3, 30, 0, 0)), new Guid("57c2aacf-ef8f-4d0b-80d2-5d09f8b7d35a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 895, DateTimeKind.Unspecified).AddTicks(3471), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b84ebb7e-fdb8-49fc-839c-3c3002c4fbda") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 895, DateTimeKind.Unspecified).AddTicks(3473), new TimeSpan(0, 3, 30, 0, 0)), new Guid("90d57763-be1c-488d-bc35-6a22f1419878") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 895, DateTimeKind.Unspecified).AddTicks(3475), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4a2ef78b-caa0-4ea7-87e3-c5408a74ba9a") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 893, DateTimeKind.Unspecified).AddTicks(1936), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a260d8aa-9c40-4eca-ad37-0e6765f5a448") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 894, DateTimeKind.Unspecified).AddTicks(1591), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e46c9246-dab9-470d-9c35-b482e6b442d3") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 894, DateTimeKind.Unspecified).AddTicks(1601), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b143965c-e719-4afa-a14e-ce259e63f16a") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 894, DateTimeKind.Unspecified).AddTicks(1605), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cfc51243-34a8-4ca8-9fdd-a6c91783517d") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 892, DateTimeKind.Unspecified).AddTicks(4671), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6521c623-dc0b-496b-bacd-9258a496a70b") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 894, DateTimeKind.Unspecified).AddTicks(5359), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9ef50426-961d-44cc-abfe-44e066c898e5") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 894, DateTimeKind.Unspecified).AddTicks(5699), new TimeSpan(0, 3, 30, 0, 0)), new Guid("bbd7ffd7-24de-4f68-a811-968f78aa27e5") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 890, DateTimeKind.Unspecified).AddTicks(2297), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e1a5a242-c1b0-462b-b543-1ef52248eca7") });

            migrationBuilder.AddForeignKey(
                name: "FK_D_Tag_D_TagCategory_TagCategoryId",
                schema: "Dimentions",
                table: "D_Tag",
                column: "TagCategoryId",
                principalSchema: "Dimentions",
                principalTable: "D_TagCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_D_Tag_D_TagType_TagTypeId",
                schema: "Dimentions",
                table: "D_Tag",
                column: "TagTypeId",
                principalSchema: "Dimentions",
                principalTable: "D_TagType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_D_User_D_User_DelegateId",
                schema: "Dimentions",
                table: "D_User",
                column: "DelegateId",
                principalSchema: "Dimentions",
                principalTable: "D_User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_F_Case_D_CaseState_CaseStateId",
                schema: "Facts",
                table: "F_Case",
                column: "CaseStateId",
                principalSchema: "Dimentions",
                principalTable: "D_CaseState",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_F_Case_D_Process_ProcessId",
                schema: "Facts",
                table: "F_Case",
                column: "ProcessId",
                principalSchema: "Dimentions",
                principalTable: "D_Process",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_F_Case_D_User_CreatorId",
                schema: "Facts",
                table: "F_Case",
                column: "CreatorId",
                principalSchema: "Dimentions",
                principalTable: "D_User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_F_Case_D_User_RequestorId",
                schema: "Facts",
                table: "F_Case",
                column: "RequestorId",
                principalSchema: "Dimentions",
                principalTable: "D_User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_F_Case_F_Scenario_SelectedScenarioId",
                schema: "Facts",
                table: "F_Case",
                column: "SelectedScenarioId",
                principalSchema: "Facts",
                principalTable: "F_Scenario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_F_Condition_D_Operand_OperandId",
                schema: "Facts",
                table: "F_Condition",
                column: "OperandId",
                principalSchema: "Dimentions",
                principalTable: "D_Operand",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_F_Condition_D_Tag_TagId",
                schema: "Facts",
                table: "F_Condition",
                column: "TagId",
                principalSchema: "Dimentions",
                principalTable: "D_Tag",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_F_Task_F_Scenario_ScenarioId",
                schema: "Facts",
                table: "F_Task",
                column: "ScenarioId",
                principalSchema: "Facts",
                principalTable: "F_Scenario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_F_WorkItem_D_User_UserId",
                schema: "Facts",
                table: "F_WorkItem",
                column: "UserId",
                principalSchema: "Dimentions",
                principalTable: "D_User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_F_WorkItem_D_WorkItemState_WorkItemStateId",
                schema: "Facts",
                table: "F_WorkItem",
                column: "WorkItemStateId",
                principalSchema: "Dimentions",
                principalTable: "D_WorkItemState",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_F_WorkItem_F_Case_CaseId",
                schema: "Facts",
                table: "F_WorkItem",
                column: "CaseId",
                principalSchema: "Facts",
                principalTable: "F_Case",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_F_WorkItem_F_Task_TaskId",
                schema: "Facts",
                table: "F_WorkItem",
                column: "TaskId",
                principalSchema: "Facts",
                principalTable: "F_Task",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_L_CaseCondition_F_Case_FirstId",
                schema: "Links",
                table: "L_CaseCondition",
                column: "FirstId",
                principalSchema: "Facts",
                principalTable: "F_Case",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_L_CaseCondition_F_Condition_SecondId",
                schema: "Links",
                table: "L_CaseCondition",
                column: "SecondId",
                principalSchema: "Facts",
                principalTable: "F_Condition",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_L_CaseTaskUser_D_User_ThirdId",
                schema: "Links",
                table: "L_CaseTaskUser",
                column: "ThirdId",
                principalSchema: "Dimentions",
                principalTable: "D_User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_L_CaseTaskUser_F_Case_FirstId",
                schema: "Links",
                table: "L_CaseTaskUser",
                column: "FirstId",
                principalSchema: "Facts",
                principalTable: "F_Case",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_L_CaseTaskUser_F_Task_SecondId",
                schema: "Links",
                table: "L_CaseTaskUser",
                column: "SecondId",
                principalSchema: "Facts",
                principalTable: "F_Task",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_L_FlowCondition_F_Condition_SecondId",
                schema: "Links",
                table: "L_FlowCondition",
                column: "SecondId",
                principalSchema: "Facts",
                principalTable: "F_Condition",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_L_FlowCondition_F_Flow_FirstId",
                schema: "Links",
                table: "L_FlowCondition",
                column: "FirstId",
                principalSchema: "Facts",
                principalTable: "F_Flow",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_L_FlowTask_F_Flow_FirstId",
                schema: "Links",
                table: "L_FlowTask",
                column: "FirstId",
                principalSchema: "Facts",
                principalTable: "F_Flow",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_L_FlowTask_F_Task_SecondId",
                schema: "Links",
                table: "L_FlowTask",
                column: "SecondId",
                principalSchema: "Facts",
                principalTable: "F_Task",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_L_ProcessScenario_D_Process_FirstId",
                schema: "Links",
                table: "L_ProcessScenario",
                column: "FirstId",
                principalSchema: "Dimentions",
                principalTable: "D_Process",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_L_ProcessScenario_F_Scenario_SecondId",
                schema: "Links",
                table: "L_ProcessScenario",
                column: "SecondId",
                principalSchema: "Facts",
                principalTable: "F_Scenario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_L_ScenarioCondition_F_Condition_SecondId",
                schema: "Links",
                table: "L_ScenarioCondition",
                column: "SecondId",
                principalSchema: "Facts",
                principalTable: "F_Condition",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_L_ScenarioCondition_F_Scenario_FirstId",
                schema: "Links",
                table: "L_ScenarioCondition",
                column: "FirstId",
                principalSchema: "Facts",
                principalTable: "F_Scenario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_L_TaskCondition_F_Condition_SecondId",
                schema: "Links",
                table: "L_TaskCondition",
                column: "SecondId",
                principalSchema: "Facts",
                principalTable: "F_Condition",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_L_TaskCondition_F_Task_FirstId",
                schema: "Links",
                table: "L_TaskCondition",
                column: "FirstId",
                principalSchema: "Facts",
                principalTable: "F_Task",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_L_TaskFlow_F_Flow_SecondId",
                schema: "Links",
                table: "L_TaskFlow",
                column: "SecondId",
                principalSchema: "Facts",
                principalTable: "F_Flow",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_L_TaskFlow_F_Task_FirstId",
                schema: "Links",
                table: "L_TaskFlow",
                column: "FirstId",
                principalSchema: "Facts",
                principalTable: "F_Task",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_L_UserCondition_D_User_FirstId",
                schema: "Links",
                table: "L_UserCondition",
                column: "FirstId",
                principalSchema: "Dimentions",
                principalTable: "D_User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_L_UserCondition_F_Condition_SecondId",
                schema: "Links",
                table: "L_UserCondition",
                column: "SecondId",
                principalSchema: "Facts",
                principalTable: "F_Condition",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_L_WorkItemCondition_F_Condition_SecondId",
                schema: "Links",
                table: "L_WorkItemCondition",
                column: "SecondId",
                principalSchema: "Facts",
                principalTable: "F_Condition",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_L_WorkItemCondition_F_WorkItem_FirstId",
                schema: "Links",
                table: "L_WorkItemCondition",
                column: "FirstId",
                principalSchema: "Facts",
                principalTable: "F_WorkItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_D_Tag_D_TagCategory_TagCategoryId",
                schema: "Dimentions",
                table: "D_Tag");

            migrationBuilder.DropForeignKey(
                name: "FK_D_Tag_D_TagType_TagTypeId",
                schema: "Dimentions",
                table: "D_Tag");

            migrationBuilder.DropForeignKey(
                name: "FK_D_User_D_User_DelegateId",
                schema: "Dimentions",
                table: "D_User");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Case_D_CaseState_CaseStateId",
                schema: "Facts",
                table: "F_Case");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Case_D_Process_ProcessId",
                schema: "Facts",
                table: "F_Case");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Case_D_User_CreatorId",
                schema: "Facts",
                table: "F_Case");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Case_D_User_RequestorId",
                schema: "Facts",
                table: "F_Case");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Case_F_Scenario_SelectedScenarioId",
                schema: "Facts",
                table: "F_Case");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Condition_D_Operand_OperandId",
                schema: "Facts",
                table: "F_Condition");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Condition_D_Tag_TagId",
                schema: "Facts",
                table: "F_Condition");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Task_F_Scenario_ScenarioId",
                schema: "Facts",
                table: "F_Task");

            migrationBuilder.DropForeignKey(
                name: "FK_F_WorkItem_D_User_UserId",
                schema: "Facts",
                table: "F_WorkItem");

            migrationBuilder.DropForeignKey(
                name: "FK_F_WorkItem_D_WorkItemState_WorkItemStateId",
                schema: "Facts",
                table: "F_WorkItem");

            migrationBuilder.DropForeignKey(
                name: "FK_F_WorkItem_F_Case_CaseId",
                schema: "Facts",
                table: "F_WorkItem");

            migrationBuilder.DropForeignKey(
                name: "FK_F_WorkItem_F_Task_TaskId",
                schema: "Facts",
                table: "F_WorkItem");

            migrationBuilder.DropForeignKey(
                name: "FK_L_CaseCondition_F_Case_FirstId",
                schema: "Links",
                table: "L_CaseCondition");

            migrationBuilder.DropForeignKey(
                name: "FK_L_CaseCondition_F_Condition_SecondId",
                schema: "Links",
                table: "L_CaseCondition");

            migrationBuilder.DropForeignKey(
                name: "FK_L_CaseTaskUser_D_User_ThirdId",
                schema: "Links",
                table: "L_CaseTaskUser");

            migrationBuilder.DropForeignKey(
                name: "FK_L_CaseTaskUser_F_Case_FirstId",
                schema: "Links",
                table: "L_CaseTaskUser");

            migrationBuilder.DropForeignKey(
                name: "FK_L_CaseTaskUser_F_Task_SecondId",
                schema: "Links",
                table: "L_CaseTaskUser");

            migrationBuilder.DropForeignKey(
                name: "FK_L_FlowCondition_F_Condition_SecondId",
                schema: "Links",
                table: "L_FlowCondition");

            migrationBuilder.DropForeignKey(
                name: "FK_L_FlowCondition_F_Flow_FirstId",
                schema: "Links",
                table: "L_FlowCondition");

            migrationBuilder.DropForeignKey(
                name: "FK_L_FlowTask_F_Flow_FirstId",
                schema: "Links",
                table: "L_FlowTask");

            migrationBuilder.DropForeignKey(
                name: "FK_L_FlowTask_F_Task_SecondId",
                schema: "Links",
                table: "L_FlowTask");

            migrationBuilder.DropForeignKey(
                name: "FK_L_ProcessScenario_D_Process_FirstId",
                schema: "Links",
                table: "L_ProcessScenario");

            migrationBuilder.DropForeignKey(
                name: "FK_L_ProcessScenario_F_Scenario_SecondId",
                schema: "Links",
                table: "L_ProcessScenario");

            migrationBuilder.DropForeignKey(
                name: "FK_L_ScenarioCondition_F_Condition_SecondId",
                schema: "Links",
                table: "L_ScenarioCondition");

            migrationBuilder.DropForeignKey(
                name: "FK_L_ScenarioCondition_F_Scenario_FirstId",
                schema: "Links",
                table: "L_ScenarioCondition");

            migrationBuilder.DropForeignKey(
                name: "FK_L_TaskCondition_F_Condition_SecondId",
                schema: "Links",
                table: "L_TaskCondition");

            migrationBuilder.DropForeignKey(
                name: "FK_L_TaskCondition_F_Task_FirstId",
                schema: "Links",
                table: "L_TaskCondition");

            migrationBuilder.DropForeignKey(
                name: "FK_L_TaskFlow_F_Flow_SecondId",
                schema: "Links",
                table: "L_TaskFlow");

            migrationBuilder.DropForeignKey(
                name: "FK_L_TaskFlow_F_Task_FirstId",
                schema: "Links",
                table: "L_TaskFlow");

            migrationBuilder.DropForeignKey(
                name: "FK_L_UserCondition_D_User_FirstId",
                schema: "Links",
                table: "L_UserCondition");

            migrationBuilder.DropForeignKey(
                name: "FK_L_UserCondition_F_Condition_SecondId",
                schema: "Links",
                table: "L_UserCondition");

            migrationBuilder.DropForeignKey(
                name: "FK_L_WorkItemCondition_F_Condition_SecondId",
                schema: "Links",
                table: "L_WorkItemCondition");

            migrationBuilder.DropForeignKey(
                name: "FK_L_WorkItemCondition_F_WorkItem_FirstId",
                schema: "Links",
                table: "L_WorkItemCondition");

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 923, DateTimeKind.Unspecified).AddTicks(2990), new TimeSpan(0, 3, 30, 0, 0)), new Guid("eee29dde-7544-4420-95c1-1b4d5c7a68e5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 923, DateTimeKind.Unspecified).AddTicks(3000), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1d5512a8-9c80-4eca-86b3-98954dbb8aa8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 923, DateTimeKind.Unspecified).AddTicks(3003), new TimeSpan(0, 3, 30, 0, 0)), new Guid("041e96b2-f44b-40ed-a521-713d0551af0e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 923, DateTimeKind.Unspecified).AddTicks(3005), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f49b8f9f-10e7-4462-b946-829288f723bd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 923, DateTimeKind.Unspecified).AddTicks(3012), new TimeSpan(0, 3, 30, 0, 0)), new Guid("005ad7b8-f2b0-4e07-8007-5adb894b7b9a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 923, DateTimeKind.Unspecified).AddTicks(3014), new TimeSpan(0, 3, 30, 0, 0)), new Guid("727f87cb-b937-420d-8cce-72d8f16761e1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 924, DateTimeKind.Unspecified).AddTicks(5953), new TimeSpan(0, 3, 30, 0, 0)), new Guid("03e9768c-f894-4b26-8fe2-b6241cdd8183") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 925, DateTimeKind.Unspecified).AddTicks(5668), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5dc8d070-7111-4a95-9328-72a1f3fa4825") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 925, DateTimeKind.Unspecified).AddTicks(5694), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9bf2f79a-6c93-4318-b0bc-5c99f84f3ac8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 925, DateTimeKind.Unspecified).AddTicks(5700), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9ba78806-7474-4fba-a53c-c604ba444228") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 925, DateTimeKind.Unspecified).AddTicks(5715), new TimeSpan(0, 3, 30, 0, 0)), new Guid("17f91e36-aa59-44d8-980b-bdddef26d4dd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 925, DateTimeKind.Unspecified).AddTicks(5721), new TimeSpan(0, 3, 30, 0, 0)), new Guid("732f9e67-5b6f-4440-ab0c-1ebf3bea63f4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 925, DateTimeKind.Unspecified).AddTicks(5726), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9788bb74-3b1f-4fae-b929-fd207e5bdc7d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 925, DateTimeKind.Unspecified).AddTicks(5731), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a80eef83-65ff-4b60-84da-2efb0609f9bb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 925, DateTimeKind.Unspecified).AddTicks(5741), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0cdf10ab-c56e-4cd0-a5c0-ae228153a8e2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 925, DateTimeKind.Unspecified).AddTicks(5746), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6d80bae1-41bf-42eb-b612-081b8d1ecc13") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 925, DateTimeKind.Unspecified).AddTicks(5751), new TimeSpan(0, 3, 30, 0, 0)), new Guid("081de6db-6549-4ab8-b19b-912f3b682429") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 925, DateTimeKind.Unspecified).AddTicks(5756), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c0b4a1c2-f0fe-443f-9900-280607ee3dad") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 925, DateTimeKind.Unspecified).AddTicks(5763), new TimeSpan(0, 3, 30, 0, 0)), new Guid("739303ff-2310-494f-b999-61c1491e50f9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 925, DateTimeKind.Unspecified).AddTicks(5767), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f97ca56c-0d71-4e56-8d2f-0142faa433ac") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 922, DateTimeKind.Unspecified).AddTicks(8585), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a6cd53d5-f7f0-41ff-af76-fde465da6abe") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 922, DateTimeKind.Unspecified).AddTicks(8604), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cecb4495-1860-410c-996f-59e5092b7aa1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 922, DateTimeKind.Unspecified).AddTicks(8607), new TimeSpan(0, 3, 30, 0, 0)), new Guid("48685e48-4004-41fb-9cad-89c356e07a78") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 922, DateTimeKind.Unspecified).AddTicks(8609), new TimeSpan(0, 3, 30, 0, 0)), new Guid("269d741e-2c8f-4255-a769-2fbff1b6b85e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 922, DateTimeKind.Unspecified).AddTicks(8612), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7a1810e7-c8dd-41ae-9d8e-a19942ce1f1a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 922, DateTimeKind.Unspecified).AddTicks(8614), new TimeSpan(0, 3, 30, 0, 0)), new Guid("146fd180-75f7-4059-8625-6e0135c4174f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 921, DateTimeKind.Unspecified).AddTicks(1332), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6dce95b7-fc2b-4991-82d9-0ac037cbae4d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 922, DateTimeKind.Unspecified).AddTicks(2046), new TimeSpan(0, 3, 30, 0, 0)), new Guid("128fd601-e938-41dd-9ddb-876f385da093") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 922, DateTimeKind.Unspecified).AddTicks(4510), new TimeSpan(0, 3, 30, 0, 0)), new Guid("09c22ee5-4423-43cd-8e7c-1f5468d4fa6a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 922, DateTimeKind.Unspecified).AddTicks(4515), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4d8f61a6-7d64-4494-bf02-fea3c4fdd364") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 922, DateTimeKind.Unspecified).AddTicks(4519), new TimeSpan(0, 3, 30, 0, 0)), new Guid("35504dbd-002d-4475-92d6-07cd9ede807e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 922, DateTimeKind.Unspecified).AddTicks(4522), new TimeSpan(0, 3, 30, 0, 0)), new Guid("335112fc-d862-49a7-b7d4-a08efef10ed5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 922, DateTimeKind.Unspecified).AddTicks(4525), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5285c932-b918-4249-97f9-cb36cc7b105e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 922, DateTimeKind.Unspecified).AddTicks(4532), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a23561f9-774a-4e11-803b-ef1b69316bd2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 922, DateTimeKind.Unspecified).AddTicks(4368), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7c703f04-6a3d-4850-bb36-391bb6392120") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 922, DateTimeKind.Unspecified).AddTicks(4378), new TimeSpan(0, 3, 30, 0, 0)), new Guid("457714f4-1f1b-41b9-b11c-6aa2e61fa541") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 922, DateTimeKind.Unspecified).AddTicks(3122), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6558dfeb-9cc7-48f2-8da2-25333f0c0527") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 922, DateTimeKind.Unspecified).AddTicks(3129), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ef96ee34-8852-42c9-a0bd-e937cce8299e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 922, DateTimeKind.Unspecified).AddTicks(3132), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2d28c910-caf2-451c-b8c0-ade408702bb4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 922, DateTimeKind.Unspecified).AddTicks(3144), new TimeSpan(0, 3, 30, 0, 0)), new Guid("44160268-e447-454d-bd02-98355a48d86b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 923, DateTimeKind.Unspecified).AddTicks(7483), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6e03c8c6-1720-4676-be6f-e14906667d92") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 923, DateTimeKind.Unspecified).AddTicks(7511), new TimeSpan(0, 3, 30, 0, 0)), new Guid("79e74505-3113-4c20-8643-5c8a0fa7bc8c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 923, DateTimeKind.Unspecified).AddTicks(4207), new TimeSpan(0, 3, 30, 0, 0)), new Guid("41ce4de8-04da-4a1d-ac93-d6f75fdfa448") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 923, DateTimeKind.Unspecified).AddTicks(4211), new TimeSpan(0, 3, 30, 0, 0)), new Guid("96e91845-a76a-47ed-af65-63a681dd961d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 923, DateTimeKind.Unspecified).AddTicks(4214), new TimeSpan(0, 3, 30, 0, 0)), new Guid("91eaee83-1d2e-4628-912e-2eb09d1547af") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 923, DateTimeKind.Unspecified).AddTicks(4216), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b9bf0c12-5083-4674-8b2f-5357f047ee12") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 921, DateTimeKind.Unspecified).AddTicks(8635), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5b8f3eb4-1acd-4197-b908-8ed5575ad287") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 922, DateTimeKind.Unspecified).AddTicks(8996), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8db44612-3ddc-4084-9009-f8eda4e0d48c") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 922, DateTimeKind.Unspecified).AddTicks(9008), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f647e5af-b2d3-4d53-8019-e14b637695e2") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 922, DateTimeKind.Unspecified).AddTicks(9012), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1b1b0ff4-83c3-4a1e-a8f5-c000b9b35699") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 921, DateTimeKind.Unspecified).AddTicks(2769), new TimeSpan(0, 3, 30, 0, 0)), new Guid("66360de1-d1f3-4379-a103-ac601e9b6b0c") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 923, DateTimeKind.Unspecified).AddTicks(1095), new TimeSpan(0, 3, 30, 0, 0)), new Guid("fd70b676-0d97-4d95-8eda-bc100b4bab14") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 923, DateTimeKind.Unspecified).AddTicks(1271), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3f72dc05-b236-4bb3-8ffc-bb235e56acb6") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 12, 49, 59, 919, DateTimeKind.Unspecified).AddTicks(4316), new TimeSpan(0, 3, 30, 0, 0)), new Guid("998fff66-da2e-47f9-b33b-5869f9e7c745") });

            migrationBuilder.AddForeignKey(
                name: "FK_D_Tag_D_TagCategory_TagCategoryId",
                schema: "Dimentions",
                table: "D_Tag",
                column: "TagCategoryId",
                principalSchema: "Dimentions",
                principalTable: "D_TagCategory",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_D_Tag_D_TagType_TagTypeId",
                schema: "Dimentions",
                table: "D_Tag",
                column: "TagTypeId",
                principalSchema: "Dimentions",
                principalTable: "D_TagType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_D_User_D_User_DelegateId",
                schema: "Dimentions",
                table: "D_User",
                column: "DelegateId",
                principalSchema: "Dimentions",
                principalTable: "D_User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Case_D_CaseState_CaseStateId",
                schema: "Facts",
                table: "F_Case",
                column: "CaseStateId",
                principalSchema: "Dimentions",
                principalTable: "D_CaseState",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Case_D_Process_ProcessId",
                schema: "Facts",
                table: "F_Case",
                column: "ProcessId",
                principalSchema: "Dimentions",
                principalTable: "D_Process",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Case_D_User_CreatorId",
                schema: "Facts",
                table: "F_Case",
                column: "CreatorId",
                principalSchema: "Dimentions",
                principalTable: "D_User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Case_D_User_RequestorId",
                schema: "Facts",
                table: "F_Case",
                column: "RequestorId",
                principalSchema: "Dimentions",
                principalTable: "D_User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Case_F_Scenario_SelectedScenarioId",
                schema: "Facts",
                table: "F_Case",
                column: "SelectedScenarioId",
                principalSchema: "Facts",
                principalTable: "F_Scenario",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Condition_D_Operand_OperandId",
                schema: "Facts",
                table: "F_Condition",
                column: "OperandId",
                principalSchema: "Dimentions",
                principalTable: "D_Operand",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Condition_D_Tag_TagId",
                schema: "Facts",
                table: "F_Condition",
                column: "TagId",
                principalSchema: "Dimentions",
                principalTable: "D_Tag",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Task_F_Scenario_ScenarioId",
                schema: "Facts",
                table: "F_Task",
                column: "ScenarioId",
                principalSchema: "Facts",
                principalTable: "F_Scenario",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_WorkItem_D_User_UserId",
                schema: "Facts",
                table: "F_WorkItem",
                column: "UserId",
                principalSchema: "Dimentions",
                principalTable: "D_User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_WorkItem_D_WorkItemState_WorkItemStateId",
                schema: "Facts",
                table: "F_WorkItem",
                column: "WorkItemStateId",
                principalSchema: "Dimentions",
                principalTable: "D_WorkItemState",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_WorkItem_F_Case_CaseId",
                schema: "Facts",
                table: "F_WorkItem",
                column: "CaseId",
                principalSchema: "Facts",
                principalTable: "F_Case",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_WorkItem_F_Task_TaskId",
                schema: "Facts",
                table: "F_WorkItem",
                column: "TaskId",
                principalSchema: "Facts",
                principalTable: "F_Task",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_L_CaseCondition_F_Case_FirstId",
                schema: "Links",
                table: "L_CaseCondition",
                column: "FirstId",
                principalSchema: "Facts",
                principalTable: "F_Case",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_L_CaseCondition_F_Condition_SecondId",
                schema: "Links",
                table: "L_CaseCondition",
                column: "SecondId",
                principalSchema: "Facts",
                principalTable: "F_Condition",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_L_CaseTaskUser_D_User_ThirdId",
                schema: "Links",
                table: "L_CaseTaskUser",
                column: "ThirdId",
                principalSchema: "Dimentions",
                principalTable: "D_User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_L_CaseTaskUser_F_Case_FirstId",
                schema: "Links",
                table: "L_CaseTaskUser",
                column: "FirstId",
                principalSchema: "Facts",
                principalTable: "F_Case",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_L_CaseTaskUser_F_Task_SecondId",
                schema: "Links",
                table: "L_CaseTaskUser",
                column: "SecondId",
                principalSchema: "Facts",
                principalTable: "F_Task",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_L_FlowCondition_F_Condition_SecondId",
                schema: "Links",
                table: "L_FlowCondition",
                column: "SecondId",
                principalSchema: "Facts",
                principalTable: "F_Condition",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_L_FlowCondition_F_Flow_FirstId",
                schema: "Links",
                table: "L_FlowCondition",
                column: "FirstId",
                principalSchema: "Facts",
                principalTable: "F_Flow",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_L_FlowTask_F_Flow_FirstId",
                schema: "Links",
                table: "L_FlowTask",
                column: "FirstId",
                principalSchema: "Facts",
                principalTable: "F_Flow",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_L_FlowTask_F_Task_SecondId",
                schema: "Links",
                table: "L_FlowTask",
                column: "SecondId",
                principalSchema: "Facts",
                principalTable: "F_Task",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_L_ProcessScenario_D_Process_FirstId",
                schema: "Links",
                table: "L_ProcessScenario",
                column: "FirstId",
                principalSchema: "Dimentions",
                principalTable: "D_Process",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_L_ProcessScenario_F_Scenario_SecondId",
                schema: "Links",
                table: "L_ProcessScenario",
                column: "SecondId",
                principalSchema: "Facts",
                principalTable: "F_Scenario",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_L_ScenarioCondition_F_Condition_SecondId",
                schema: "Links",
                table: "L_ScenarioCondition",
                column: "SecondId",
                principalSchema: "Facts",
                principalTable: "F_Condition",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_L_ScenarioCondition_F_Scenario_FirstId",
                schema: "Links",
                table: "L_ScenarioCondition",
                column: "FirstId",
                principalSchema: "Facts",
                principalTable: "F_Scenario",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_L_TaskCondition_F_Condition_SecondId",
                schema: "Links",
                table: "L_TaskCondition",
                column: "SecondId",
                principalSchema: "Facts",
                principalTable: "F_Condition",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_L_TaskCondition_F_Task_FirstId",
                schema: "Links",
                table: "L_TaskCondition",
                column: "FirstId",
                principalSchema: "Facts",
                principalTable: "F_Task",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_L_TaskFlow_F_Flow_SecondId",
                schema: "Links",
                table: "L_TaskFlow",
                column: "SecondId",
                principalSchema: "Facts",
                principalTable: "F_Flow",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_L_TaskFlow_F_Task_FirstId",
                schema: "Links",
                table: "L_TaskFlow",
                column: "FirstId",
                principalSchema: "Facts",
                principalTable: "F_Task",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_L_UserCondition_D_User_FirstId",
                schema: "Links",
                table: "L_UserCondition",
                column: "FirstId",
                principalSchema: "Dimentions",
                principalTable: "D_User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_L_UserCondition_F_Condition_SecondId",
                schema: "Links",
                table: "L_UserCondition",
                column: "SecondId",
                principalSchema: "Facts",
                principalTable: "F_Condition",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_L_WorkItemCondition_F_Condition_SecondId",
                schema: "Links",
                table: "L_WorkItemCondition",
                column: "SecondId",
                principalSchema: "Facts",
                principalTable: "F_Condition",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_L_WorkItemCondition_F_WorkItem_FirstId",
                schema: "Links",
                table: "L_WorkItemCondition",
                column: "FirstId",
                principalSchema: "Facts",
                principalTable: "F_WorkItem",
                principalColumn: "Id");
        }
    }
}
