﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class PrimeraMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "accesos",
                columns: table => new
                {
                    id_acceso = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    codigo_acceso = table.Column<string>(type: "text", nullable: true),
                    descripcion_acceso = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_accesos", x => x.id_acceso);
                });

            migrationBuilder.CreateTable(
                name: "autores",
                columns: table => new
                {
                    id_autor = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre_autor = table.Column<string>(type: "text", nullable: false),
                    apellidos_autor = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_autores", x => x.id_autor);
                });

            migrationBuilder.CreateTable(
                name: "colecciones",
                columns: table => new
                {
                    id_coleccion = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre_coleccion = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_colecciones", x => x.id_coleccion);
                });

            migrationBuilder.CreateTable(
                name: "editoriales",
                columns: table => new
                {
                    id_editorial = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre_editorial = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_editoriales", x => x.id_editorial);
                });

            migrationBuilder.CreateTable(
                name: "estados_Prestamos",
                columns: table => new
                {
                    id_estado_prestamo = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    codigo_estado_prestamo = table.Column<string>(type: "text", nullable: false),
                    descripcion_estado_prestamo = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_estados_Prestamos", x => x.id_estado_prestamo);
                });

            migrationBuilder.CreateTable(
                name: "generos",
                columns: table => new
                {
                    id_genero = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre_genero = table.Column<string>(type: "text", nullable: true),
                    descripcion_genero = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_generos", x => x.id_genero);
                });

            migrationBuilder.CreateTable(
                name: "usuarios",
                columns: table => new
                {
                    id_usuario = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    dni_usuario = table.Column<string>(type: "text", nullable: false),
                    nombre_usuario = table.Column<string>(type: "text", nullable: true),
                    apellidos_usuario = table.Column<string>(type: "text", nullable: true),
                    tlf_usuario = table.Column<string>(type: "text", nullable: true),
                    email_usuario = table.Column<string>(type: "text", nullable: true),
                    clave_usuario = table.Column<string>(type: "text", nullable: false),
                    id_acceso = table.Column<int>(type: "integer", nullable: false),
                    estaBloqueado_usuario = table.Column<bool>(type: "boolean", nullable: true),
                    fch_fin_bloqueo_usuario = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    fch_alta_usuario = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    fch_baja_usuario = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarios", x => x.id_usuario);
                    table.ForeignKey(
                        name: "FK_usuarios_accesos_id_acceso",
                        column: x => x.id_acceso,
                        principalTable: "accesos",
                        principalColumn: "id_acceso",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "libros",
                columns: table => new
                {
                    id_libro = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    isbn_libro = table.Column<string>(type: "text", nullable: true),
                    titulo_libro = table.Column<string>(type: "text", nullable: true),
                    edicion_libro = table.Column<string>(type: "text", nullable: true),
                    cantidad_libro = table.Column<int>(type: "integer", nullable: true),
                    id_editorial = table.Column<int>(type: "integer", nullable: false),
                    id_genero = table.Column<int>(type: "integer", nullable: false),
                    id_coleccion = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_libros", x => x.id_libro);
                    table.ForeignKey(
                        name: "FK_libros_colecciones_id_coleccion",
                        column: x => x.id_coleccion,
                        principalTable: "colecciones",
                        principalColumn: "id_coleccion",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_libros_editoriales_id_editorial",
                        column: x => x.id_editorial,
                        principalTable: "editoriales",
                        principalColumn: "id_editorial",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_libros_generos_id_genero",
                        column: x => x.id_genero,
                        principalTable: "generos",
                        principalColumn: "id_genero",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "prestamos",
                columns: table => new
                {
                    id_prestamo = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    id_usuario = table.Column<int>(type: "integer", nullable: false),
                    fch_inicio_prestamo = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    fch_fin_prestamo = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    fch_entrega_prestamo = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    id_estado_prestamo = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prestamos", x => x.id_prestamo);
                    table.ForeignKey(
                        name: "FK_prestamos_estados_Prestamos_id_estado_prestamo",
                        column: x => x.id_estado_prestamo,
                        principalTable: "estados_Prestamos",
                        principalColumn: "id_estado_prestamo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_prestamos_usuarios_id_usuario",
                        column: x => x.id_usuario,
                        principalTable: "usuarios",
                        principalColumn: "id_usuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "rel_Autores_Libros",
                columns: table => new
                {
                    id_autor = table.Column<int>(type: "integer", nullable: false),
                    id_libro = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rel_Autores_Libros", x => new { x.id_autor, x.id_libro });
                    table.ForeignKey(
                        name: "FK_rel_Autores_Libros_autores_id_autor",
                        column: x => x.id_autor,
                        principalTable: "autores",
                        principalColumn: "id_autor",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_rel_Autores_Libros_libros_id_libro",
                        column: x => x.id_libro,
                        principalTable: "libros",
                        principalColumn: "id_libro",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "rel_Libros_Prestamos",
                columns: table => new
                {
                    id_prestamo = table.Column<int>(type: "integer", nullable: false),
                    id_libro = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rel_Libros_Prestamos", x => new { x.id_prestamo, x.id_libro });
                    table.ForeignKey(
                        name: "FK_rel_Libros_Prestamos_libros_id_libro",
                        column: x => x.id_libro,
                        principalTable: "libros",
                        principalColumn: "id_libro",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_rel_Libros_Prestamos_prestamos_id_prestamo",
                        column: x => x.id_prestamo,
                        principalTable: "prestamos",
                        principalColumn: "id_prestamo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_libros_id_coleccion",
                table: "libros",
                column: "id_coleccion");

            migrationBuilder.CreateIndex(
                name: "IX_libros_id_editorial",
                table: "libros",
                column: "id_editorial");

            migrationBuilder.CreateIndex(
                name: "IX_libros_id_genero",
                table: "libros",
                column: "id_genero");

            migrationBuilder.CreateIndex(
                name: "IX_prestamos_id_estado_prestamo",
                table: "prestamos",
                column: "id_estado_prestamo");

            migrationBuilder.CreateIndex(
                name: "IX_prestamos_id_usuario",
                table: "prestamos",
                column: "id_usuario");

            migrationBuilder.CreateIndex(
                name: "IX_rel_Autores_Libros_id_libro",
                table: "rel_Autores_Libros",
                column: "id_libro");

            migrationBuilder.CreateIndex(
                name: "IX_rel_Libros_Prestamos_id_libro",
                table: "rel_Libros_Prestamos",
                column: "id_libro");

            migrationBuilder.CreateIndex(
                name: "IX_usuarios_id_acceso",
                table: "usuarios",
                column: "id_acceso");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "rel_Autores_Libros");

            migrationBuilder.DropTable(
                name: "rel_Libros_Prestamos");

            migrationBuilder.DropTable(
                name: "autores");

            migrationBuilder.DropTable(
                name: "libros");

            migrationBuilder.DropTable(
                name: "prestamos");

            migrationBuilder.DropTable(
                name: "colecciones");

            migrationBuilder.DropTable(
                name: "editoriales");

            migrationBuilder.DropTable(
                name: "generos");

            migrationBuilder.DropTable(
                name: "estados_Prestamos");

            migrationBuilder.DropTable(
                name: "usuarios");

            migrationBuilder.DropTable(
                name: "accesos");
        }
    }
}
