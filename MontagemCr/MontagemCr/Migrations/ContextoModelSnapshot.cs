﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MontagemCr.Models;

namespace MontagemCr.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MontagemCr.Models.Curriculo", b =>
                {
                    b.Property<int>("CurriculoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("UsuarioId");

                    b.HasKey("CurriculoId");

                    b.HasIndex("Nome")
                        .IsUnique();

                    b.HasIndex("UsuarioId");

                    b.ToTable("Curriculos");
                });

            modelBuilder.Entity("MontagemCr.Models.ExperienciaProfissional", b =>
                {
                    b.Property<int>("ExperienciaProfissionalId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AnoFim");

                    b.Property<int>("AnoInicio");

                    b.Property<string>("Cargo")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("CurriculoId");

                    b.Property<string>("DescricaoAtividades")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("NomeEmpresa")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("ExperienciaProfissionalId");

                    b.HasIndex("CurriculoId");

                    b.ToTable("ExperienciasProfissionais");
                });

            modelBuilder.Entity("MontagemCr.Models.FormacaoAcademica", b =>
                {
                    b.Property<int>("FormacaoAcademicaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AnoFim");

                    b.Property<int>("AnoInicio");

                    b.Property<int>("CurriculoId");

                    b.Property<string>("Instituicao")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("NomeCurso")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("TipoCursoId");

                    b.HasKey("FormacaoAcademicaId");

                    b.HasIndex("CurriculoId");

                    b.HasIndex("TipoCursoId");

                    b.ToTable("FormacoesAcademicas");
                });

            modelBuilder.Entity("MontagemCr.Models.Idioma", b =>
                {
                    b.Property<int>("IdiomaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CurriculoId");

                    b.Property<string>("Nivel")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("IdiomaId");

                    b.HasIndex("CurriculoId");

                    b.HasIndex("Nome")
                        .IsUnique();

                    b.ToTable("Idiomas");
                });

            modelBuilder.Entity("MontagemCr.Models.InformacaoLogin", b =>
                {
                    b.Property<int>("InformacaoLoginId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Data")
                        .IsRequired();

                    b.Property<string>("EnderecoIP")
                        .IsRequired();

                    b.Property<string>("Horario")
                        .IsRequired();

                    b.Property<int>("UsuarioId");

                    b.HasKey("InformacaoLoginId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("InformacoesLogin");
                });

            modelBuilder.Entity("MontagemCr.Models.Objetivo", b =>
                {
                    b.Property<int>("ObjetivoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CurriculoId");

                    b.Property<string>("Descrição")
                        .IsRequired()
                        .HasMaxLength(1000);

                    b.HasKey("ObjetivoId");

                    b.HasIndex("CurriculoId");

                    b.ToTable("Objetivos");
                });

            modelBuilder.Entity("MontagemCr.Models.TipoCurso", b =>
                {
                    b.Property<int>("TipoCursoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Tipo")
                        .IsRequired();

                    b.HasKey("TipoCursoId");

                    b.HasIndex("Tipo")
                        .IsUnique();

                    b.ToTable("TiposCursos");
                });

            modelBuilder.Entity("MontagemCr.Models.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("UsuarioId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("MontagemCr.Models.Curriculo", b =>
                {
                    b.HasOne("MontagemCr.Models.Usuario", "Usuario")
                        .WithMany("Curriculos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MontagemCr.Models.ExperienciaProfissional", b =>
                {
                    b.HasOne("MontagemCr.Models.Curriculo", "Curriculo")
                        .WithMany("ExperienciasProfissionais")
                        .HasForeignKey("CurriculoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MontagemCr.Models.FormacaoAcademica", b =>
                {
                    b.HasOne("MontagemCr.Models.Curriculo", "Curriculo")
                        .WithMany("FormacoesAcademicas")
                        .HasForeignKey("CurriculoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MontagemCr.Models.TipoCurso", "TipoCurso")
                        .WithMany("FormacoesAcademicas")
                        .HasForeignKey("TipoCursoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MontagemCr.Models.Idioma", b =>
                {
                    b.HasOne("MontagemCr.Models.Curriculo", "Curriculo")
                        .WithMany("Idiomas")
                        .HasForeignKey("CurriculoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MontagemCr.Models.InformacaoLogin", b =>
                {
                    b.HasOne("MontagemCr.Models.Usuario", "Usuario")
                        .WithMany("InformacoesLogin")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MontagemCr.Models.Objetivo", b =>
                {
                    b.HasOne("MontagemCr.Models.Curriculo", "Curriculo")
                        .WithMany("Objetivos")
                        .HasForeignKey("CurriculoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
