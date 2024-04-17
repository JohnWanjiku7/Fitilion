﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fitilion.Server.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GitHubCommits",
                columns: table => new
                {
                    CommitId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CommitMessage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommitDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommitAuthor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StarredTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GitHubCommits", x => x.CommitId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GitHubCommits");
        }
    }
}
