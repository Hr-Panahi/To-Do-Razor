﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace To_Do.Migrations
{
    /// <inheritdoc />
    public partial class AddTimeToTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DueTime",
                table: "ToDoTask",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DueTime",
                table: "ToDoTask");
        }
    }
}
