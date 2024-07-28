using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApplication2.Models
{
    public partial class MANAGEMENT_BPMContext : DbContext
    {
        public MANAGEMENT_BPMContext()
        {
        }

        public MANAGEMENT_BPMContext(DbContextOptions<MANAGEMENT_BPMContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DefDepartment> DefDepartments { get; set; } = null!;
        public virtual DbSet<DefInput> DefInputs { get; set; } = null!;
        public virtual DbSet<DefTag> DefTags { get; set; } = null!;
        public virtual DbSet<DefTaskStatus> DefTaskStatuses { get; set; } = null!;
        public virtual DbSet<DefTaskType> DefTaskTypes { get; set; } = null!;
        public virtual DbSet<TagFollow> TagFollows { get; set; } = null!;
        public virtual DbSet<Task> Tasks { get; set; } = null!;
        public virtual DbSet<TaskRaciC> TaskRaciCs { get; set; } = null!;
        public virtual DbSet<TaskRaciI> TaskRaciIs { get; set; } = null!;
        public virtual DbSet<TaskRaciR> TaskRaciRs { get; set; } = null!;
        public virtual DbSet<TaskRacium> TaskRaciAs { get; set; } = null!;
        public virtual DbSet<TaskStep> TaskSteps { get; set; } = null!;
        public virtual DbSet<TaskStepAction> TaskStepActions { get; set; } = null!;
        public virtual DbSet<TaskStepActionInput> TaskStepActionInputs { get; set; } = null!;
        public virtual DbSet<TaskStepInput> TaskStepInputs { get; set; } = null!;
        public virtual DbSet<TaskStepTag> TaskStepTags { get; set; } = null!;
        public virtual DbSet<TaskTag> TaskTags { get; set; } = null!;
        public virtual DbSet<TemplateTask> TemplateTasks { get; set; } = null!;
        public virtual DbSet<TemplateTaskRaci> TemplateTaskRacis { get; set; } = null!;
        public virtual DbSet<TemplateTaskStep> TemplateTaskSteps { get; set; } = null!;
        public virtual DbSet<TemplateTaskStepInput> TemplateTaskStepInputs { get; set; } = null!;
        public virtual DbSet<TemplateTaskStepTag> TemplateTaskStepTags { get; set; } = null!;
        public virtual DbSet<TemplateTaskTag> TemplateTaskTags { get; set; } = null!;
        public virtual DbSet<UserLog> UserLogs { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-MDFK9N3\\SQLEXPRESS;Database=MANAGEMENT_BPM;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Turkish_CI_AI");

            modelBuilder.Entity<DefDepartment>(entity =>
            {
                entity.ToTable("DEF_DEPARTMENT");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.RecordTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RefCustomer).HasColumnName("refCustomer");

                entity.Property(e => e.ServiceNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DefInput>(entity =>
            {
                entity.ToTable("DEF_INPUT");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.RecordTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RefCustomer).HasColumnName("refCustomer");

                entity.Property(e => e.ServiceNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Type).HasMaxLength(50);
            });

            modelBuilder.Entity<DefTag>(entity =>
            {
                entity.ToTable("DEF_TAG");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.RecordTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RefCreateUser).HasColumnName("refCreateUser");

                entity.Property(e => e.RefCustomer).HasColumnName("refCustomer");

                entity.Property(e => e.ServiceNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DefTaskStatus>(entity =>
            {
                entity.ToTable("DEF_TASK_STATUS");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.RecordTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RefCreateUser).HasColumnName("refCreateUser");

                entity.Property(e => e.RefCustomer).HasColumnName("refCustomer");

                entity.Property(e => e.RefTemplateTask).HasColumnName("refTemplateTask");

                entity.Property(e => e.ServiceNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasMaxLength(255);
            });

            modelBuilder.Entity<DefTaskType>(entity =>
            {
                entity.ToTable("DEF_TASK_TYPE");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.RecordTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RefCreateUser).HasColumnName("refCreateUser");

                entity.Property(e => e.RefCustomer).HasColumnName("refCustomer");

                entity.Property(e => e.ServiceNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TagFollow>(entity =>
            {
                entity.ToTable("TAG_FOLLOW");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.RecordTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RefTag).HasColumnName("refTag");

                entity.Property(e => e.RefUser).HasColumnName("refUser");
            });

            modelBuilder.Entity<Task>(entity =>
            {
                entity.ToTable("TASK");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BeginDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.RecordTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RefCustomer).HasColumnName("refCustomer");

                entity.Property(e => e.RefDepartment).HasColumnName("refDepartment");

                entity.Property(e => e.RefTaskStatus).HasColumnName("refTaskStatus");

                entity.Property(e => e.RefTaskStep).HasColumnName("refTaskStep");

                entity.Property(e => e.RefTemplateTask).HasColumnName("refTemplateTask");

                entity.Property(e => e.ServiceNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });
             modelBuilder.Entity<HiringDetails>(entity =>
             {
                 
            
                 entity.HasKey(e => e.DetailID);  // Set DetailID as the primary key
                 entity.ToTable("HiringDetails");
            
                 entity.Property(e => e.DetailID).HasColumnName("DetailID");
            
                 entity.Property(e => e.TaskID).HasColumnType("TaskID");
            
                 entity.Property(e => e.ResponsibleUserID).HasColumnType("ResponsibleUserID");
            
            
                 entity.Property(e => e.CompletionDate)
                     .HasColumnType("CompletionDate")
                     .HasDefaultValueSql("(getdate())");
            
                 entity.Property(e => e.ResponsibleUserName).HasColumnName("ResponsibleUserName");
            
                 entity.Property(e => e.HireName).HasColumnName("HireName");
            
                 entity.Property(e => e.Department).HasColumnName("Department");
            
                 entity.Property(e => e.StepDescription).HasColumnName("StepDescription");
            
                 entity.Property(e => e.Status).HasColumnName("Status");
            
                 entity.Property(e => e.UserName2).HasColumnName("UserName2");
            
                 entity.Property(e => e.UserName3).HasColumnName("UserName3");
            
                 entity.Property(e => e.Status2).HasColumnName("Status2");
            
                 entity.Property(e => e.Status3).HasColumnName("Status3");
            
                 entity.Property(e => e.CompletionDate2).HasColumnName("CompletionDate2");
            
                 entity.Property(e => e.CompletionDate3).HasColumnName("CompletionDate3");
            
             });
            modelBuilder.Entity<TaskRaciC>(entity =>
            {
                entity.ToTable("TASK_RACI_C");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.RecordTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RefTask).HasColumnName("refTask");

                entity.Property(e => e.RefUser).HasColumnName("refUser");
            });

            modelBuilder.Entity<TaskRaciI>(entity =>
            {
                entity.ToTable("TASK_RACI_I");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.RecordTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RefTask).HasColumnName("refTask");

                entity.Property(e => e.RefUser).HasColumnName("refUser");
            });

            modelBuilder.Entity<TaskRaciR>(entity =>
            {
                entity.ToTable("TASK_RACI_R");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.RecordTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RefTask).HasColumnName("refTask");

                entity.Property(e => e.RefUser).HasColumnName("refUser");
            });

            modelBuilder.Entity<TaskRacium>(entity =>
            {
                entity.ToTable("TASK_RACI_A");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.RecordTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RefTask).HasColumnName("refTask");

                entity.Property(e => e.RefUser).HasColumnName("refUser");
            });

            modelBuilder.Entity<TaskStep>(entity =>
            {
                entity.ToTable("TASK_STEP");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.RecordTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RefCreateUser).HasColumnName("refCreateUser");

                entity.Property(e => e.RefTask).HasColumnName("refTask");

                entity.Property(e => e.StepStatus).HasMaxLength(255);
            });

            modelBuilder.Entity<TaskStepAction>(entity =>
            {
                entity.ToTable("TASK_STEP_ACTION");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ApprovalStatus).HasMaxLength(255);

                entity.Property(e => e.RecordTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RefCreateUser).HasColumnName("refCreateUser");

                entity.Property(e => e.RefTaskStep).HasColumnName("refTaskStep");
            });

            modelBuilder.Entity<TaskStepActionInput>(entity =>
            {
                entity.ToTable("TASK_STEP_ACTION_INPUT");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.RecordTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RefTaskStepInput).HasColumnName("refTaskStepInput");
            });

            modelBuilder.Entity<TaskStepInput>(entity =>
            {
                entity.ToTable("TASK_STEP_INPUT");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.InputLabel).HasMaxLength(255);

                entity.Property(e => e.IsRequired).HasColumnName("isRequired");

                entity.Property(e => e.RecordTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RefInput).HasColumnName("refInput");

                entity.Property(e => e.RefTaskStep).HasColumnName("refTaskStep");
            });

            modelBuilder.Entity<TaskStepTag>(entity =>
            {
                entity.ToTable("TASK_STEP_TAG");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.RecordTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RefTag).HasColumnName("refTag");

                entity.Property(e => e.RefTask).HasColumnName("refTask");
            });

            modelBuilder.Entity<TaskTag>(entity =>
            {
                entity.ToTable("TASK_TAG");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.RecordTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RefTag).HasColumnName("refTag");

                entity.Property(e => e.RefTask).HasColumnName("refTask");
            });

            modelBuilder.Entity<TemplateTask>(entity =>
            {
                entity.ToTable("TEMPLATE_TASK");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.RecordTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RefCreateUser).HasColumnName("refCreateUser");

                entity.Property(e => e.RefCustomer).HasColumnName("refCustomer");

                entity.Property(e => e.RefDepartment).HasColumnName("refDepartment");

                entity.Property(e => e.RefTaskType).HasColumnName("refTaskType");

                entity.Property(e => e.ServiceNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TimingType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TemplateTaskRaci>(entity =>
            {
                entity.ToTable("TEMPLATE_TASK_RACI");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.RaciType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("raciType")
                    .IsFixedLength();

                entity.Property(e => e.RecordTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RefCreateUser).HasColumnName("refCreateUser");

                entity.Property(e => e.RefRole).HasColumnName("refRole");

                entity.Property(e => e.RefTemplateTask).HasColumnName("refTemplateTask");
            });

            modelBuilder.Entity<TemplateTaskStep>(entity =>
            {
                entity.ToTable("TEMPLATE_TASK_STEP");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.RecordTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RefCreateUser).HasColumnName("refCreateUser");

                entity.Property(e => e.RefTemplateTask).HasColumnName("refTemplateTask");
            });

            modelBuilder.Entity<TemplateTaskStepInput>(entity =>
            {
                entity.ToTable("TEMPLATE_TASK_STEP_INPUT");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.InputLabel).HasMaxLength(255);

                entity.Property(e => e.IsRequired).HasColumnName("isRequired");

                entity.Property(e => e.RecordTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RefCreateUser).HasColumnName("refCreateUser");

                entity.Property(e => e.RefInput).HasColumnName("refInput");

                entity.Property(e => e.RefTemplateTaskStep).HasColumnName("refTemplateTaskStep");
            });

            modelBuilder.Entity<TemplateTaskStepTag>(entity =>
            {
                entity.ToTable("TEMPLATE_TASK_STEP_TAG");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.RecordTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RefTag).HasColumnName("refTag");

                entity.Property(e => e.RefTemplateTask).HasColumnName("refTemplateTask");
            });

            modelBuilder.Entity<TemplateTaskTag>(entity =>
            {
                entity.ToTable("TEMPLATE_TASK_TAG");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.RecordTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RefTag).HasColumnName("refTag");

                entity.Property(e => e.RefTemplateTask).HasColumnName("refTemplateTask");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
