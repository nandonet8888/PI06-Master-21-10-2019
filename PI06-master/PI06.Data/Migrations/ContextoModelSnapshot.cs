﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PI06.Data.Context;

namespace PI06.Data.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("dbo")
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("PI06.Data.Models.Entity.Cirurgia", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("IdCirurgiaProcedimento");

                    b.Property<string>("Descricao")
                        .IsRequired();

                    b.Property<DateTime?>("DtAlteracao");

                    b.Property<DateTime>("DtInclusao");

                    b.HasKey("Id")
                        .HasName("IdCirurgiaProcedimento");

                    b.ToTable("Cirurgia");
                });

            modelBuilder.Entity("PI06.Data.Models.Entity.Consulta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IdConsulta")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataInicio");

                    b.Property<DateTime?>("DataTermino");

                    b.Property<DateTime?>("DtAlteracao");

                    b.Property<DateTime>("DtInclusao");

                    b.Property<int>("IdFuncionarioMedico");

                    b.Property<int>("IdPaciente");

                    b.HasKey("Id")
                        .HasName("IdConsulta");

                    b.HasIndex("IdFuncionarioMedico");

                    b.HasIndex("IdPaciente");

                    b.ToTable("Consulta");
                });

            modelBuilder.Entity("PI06.Data.Models.Entity.Exame", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("IdExame");

                    b.Property<DateTime?>("DtAlteracao");

                    b.Property<DateTime>("DtInclusao");

                    b.Property<int>("IdTipoExame");

                    b.Property<string>("Resultado")
                        .IsRequired();

                    b.HasKey("Id")
                        .HasName("IdExame");

                    b.HasIndex("IdTipoExame");

                    b.ToTable("Exame");
                });

            modelBuilder.Entity("PI06.Data.Models.Entity.Procedimento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("idProcedimento")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DtAlteracao");

                    b.Property<DateTime>("DtInclusao");

                    b.Property<int>("IdConsulta");

                    b.Property<int>("IdTipoProcedimento");

                    b.Property<string>("Observacao")
                        .IsRequired();

                    b.HasKey("Id")
                        .HasName("IdProcedimento");

                    b.HasIndex("IdConsulta");

                    b.HasIndex("IdTipoProcedimento");

                    b.ToTable("Procedimento");
                });

            modelBuilder.Entity("PI06.Data.Models.Entity.TipoExame", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IdTipoExame")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired();

                    b.Property<DateTime?>("DtAlteracao");

                    b.Property<DateTime>("DtInclusao");

                    b.Property<string>("ResultadoReferencia")
                        .IsRequired();

                    b.HasKey("Id")
                        .HasName("IdTipoExame");

                    b.ToTable("TipoExame");
                });

            modelBuilder.Entity("PI06.Data.Models.Entity.TipoProcedimento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IdTipoProcedimento")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired();

                    b.Property<DateTime?>("DtAlteracao");

                    b.Property<DateTime>("DtInclusao");

                    b.HasKey("Id")
                        .HasName("IdTipoProcedimento");

                    b.ToTable("TipoProcedimento");
                });

            modelBuilder.Entity("PI06.Models.Entity.Cargo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IDCargo")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescricaoCargo")
                        .IsRequired();

                    b.Property<DateTime?>("DtAlteracao");

                    b.Property<DateTime>("DtInclusao");

                    b.Property<bool>("IsHealthProfession");

                    b.HasKey("Id")
                        .HasName("IDCargo");

                    b.ToTable("Cargo");
                });

            modelBuilder.Entity("PI06.Models.Entity.Conselho", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IdConselho")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescricaoConselho");

                    b.Property<DateTime?>("DtAlteracao");

                    b.Property<DateTime>("DtInclusao");

                    b.Property<int?>("NumeroConselho");

                    b.HasKey("Id")
                        .HasName("IdConselho");

                    b.ToTable("Conselho");
                });

            modelBuilder.Entity("PI06.Models.Entity.Funcionario", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("IdFuncionario");

                    b.Property<int>("CargoId");

                    b.Property<int?>("ConselhoId");

                    b.Property<DateTime>("DataContratacao");

                    b.Property<DateTime?>("DataDemissao")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(null);

                    b.Property<DateTime?>("DtAlteracao");

                    b.Property<DateTime>("DtInclusao");

                    b.HasKey("Id")
                        .HasName("IdFuncionario");

                    b.HasIndex("CargoId");

                    b.HasIndex("ConselhoId");

                    b.ToTable("Funcionario");
                });

            modelBuilder.Entity("PI06.Models.Entity.Paciente", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("IdPaciente");

                    b.Property<DateTime?>("DtAlteracao");

                    b.Property<DateTime>("DtInclusao");

                    b.HasKey("Id")
                        .HasName("IdPaciente");

                    b.ToTable("Paciente");
                });

            modelBuilder.Entity("PI06.Models.Entity.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IdPessoa")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .IsRequired();

                    b.Property<long>("CepCod");

                    b.Property<string>("Cidade")
                        .IsRequired();

                    b.Property<long>("CodigoCpf");

                    b.Property<string>("Complemento");

                    b.Property<int>("DDD");

                    b.Property<DateTime>("DataNascimento");

                    b.Property<DateTime?>("DtAlteracao");

                    b.Property<DateTime>("DtInclusao");

                    b.Property<string>("EnderecoEmail")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("Logradouro")
                        .IsRequired();

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.Property<string>("NumeroEndereco")
                        .IsRequired();

                    b.Property<long>("NumeroTelefone");

                    b.Property<string>("Rg")
                        .IsRequired();

                    b.Property<int>("Sus");

                    b.Property<int>("Uf");

                    b.HasKey("Id")
                        .HasName("IdPessoa");

                    b.HasIndex("CodigoCpf")
                        .IsUnique();

                    b.ToTable("Pessoa");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PI06.Data.Models.Entity.Cirurgia", b =>
                {
                    b.HasOne("PI06.Data.Models.Entity.Procedimento", "Procedimento")
                        .WithOne("Cirurgia")
                        .HasForeignKey("PI06.Data.Models.Entity.Cirurgia", "Id")
                        .HasConstraintName("PFK_IdProcedimentoCirurgia")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("PI06.Data.Models.Entity.Consulta", b =>
                {
                    b.HasOne("PI06.Models.Entity.Funcionario", "FuncionarioMedico")
                        .WithMany("Consultas")
                        .HasForeignKey("IdFuncionarioMedico")
                        .HasConstraintName("FK_FuncionarioConsulta")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("PI06.Models.Entity.Paciente", "Paciente")
                        .WithMany("Consultas")
                        .HasForeignKey("IdPaciente")
                        .HasConstraintName("FK_PacienteConsulta")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("PI06.Data.Models.Entity.Exame", b =>
                {
                    b.HasOne("PI06.Data.Models.Entity.Procedimento", "Procedimento")
                        .WithOne("Exame")
                        .HasForeignKey("PI06.Data.Models.Entity.Exame", "Id")
                        .HasConstraintName("PFK_ProcedimentoExame")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("PI06.Data.Models.Entity.TipoExame", "TipoExame")
                        .WithMany("Exames")
                        .HasForeignKey("IdTipoExame")
                        .HasConstraintName("FK_IdTipoExame")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("PI06.Data.Models.Entity.Procedimento", b =>
                {
                    b.HasOne("PI06.Data.Models.Entity.Consulta", "Consulta")
                        .WithMany("Procedimentos")
                        .HasForeignKey("IdConsulta")
                        .HasConstraintName("FK_IdConsulta")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("PI06.Data.Models.Entity.TipoProcedimento", "TipoProcedimento")
                        .WithMany("Procedimentos")
                        .HasForeignKey("IdTipoProcedimento")
                        .HasConstraintName("FK_IdTipoProcedimento")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("PI06.Models.Entity.Funcionario", b =>
                {
                    b.HasOne("PI06.Models.Entity.Cargo", "Cargo")
                        .WithMany("Funcionarios")
                        .HasForeignKey("CargoId")
                        .HasConstraintName("FK_Cargo")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("PI06.Models.Entity.Conselho", "Conselho")
                        .WithMany("Funcionarios")
                        .HasForeignKey("ConselhoId")
                        .HasConstraintName("FK_Conselho")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("PI06.Models.Entity.Pessoa", "Pessoa")
                        .WithOne("Funcionario")
                        .HasForeignKey("PI06.Models.Entity.Funcionario", "Id")
                        .HasConstraintName("PFK_PessoaFuncionario")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("PI06.Models.Entity.Paciente", b =>
                {
                    b.HasOne("PI06.Models.Entity.Pessoa", "Pessoa")
                        .WithOne("Paciente")
                        .HasForeignKey("PI06.Models.Entity.Paciente", "Id")
                        .HasConstraintName("PFK_PessoaPaciente")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
