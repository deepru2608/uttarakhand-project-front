using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using uttarakhand_project_front.Models;

namespace uttarakhand_project_front.Data
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            #region Qualifying Exam Master Default Entry 
            modelBuilder.Entity<QualifyingExamDetails>().HasData(
                    new QualifyingExamDetails
                    {
                        Id = 1,
                        Name = "Graduation",
                        CourseName = "B_Ed"
                    },
                    new QualifyingExamDetails
                    {
                        Id = 2,
                        Name = "Post Graduation",
                        CourseName = "B_Ed"
                    },
                    new QualifyingExamDetails
                    {
                        Id = 3,
                        Name = "B.Ed. Theory",
                        CourseName = "M_Ed_Theory"
                    },
                    new QualifyingExamDetails
                    {
                        Id = 4,
                        Name = "B.T. Theory",
                        CourseName = "M_Ed_Theory"
                    },
                    new QualifyingExamDetails
                    {
                        Id = 5,
                        Name = "L.T. Theory",
                        CourseName = "M_Ed_Theory"
                    },
                    new QualifyingExamDetails
                    {
                        Id = 6,
                        Name = "B.EI.Ed. Theory",
                        CourseName = "M_Ed_Theory"
                    },
                    new QualifyingExamDetails
                    {
                        Id = 7,
                        Name = "D.EI.Ed. Theory",
                        CourseName = "M_Ed_Theory"
                    },
                    new QualifyingExamDetails
                    {
                        Id = 8,
                        Name = "B.A B.Ed. Theory",
                        CourseName = "M_Ed_Theory"
                    },
                    new QualifyingExamDetails
                    {
                        Id = 9,
                        Name = "B.Sc. B.Ed. Theory",
                        CourseName = "M_Ed_Theory"
                    },
                    new QualifyingExamDetails
                    {
                        Id = 10,
                        Name = "B.Ed. Practical",
                        CourseName = "M_Ed_Practical"
                    },
                    new QualifyingExamDetails
                    {
                        Id = 11,
                        Name = "B.T. Practical",
                        CourseName = "M_Ed_Practical"
                    },
                    new QualifyingExamDetails
                    {
                        Id = 12,
                        Name = "L.T. Practical",
                        CourseName = "M_Ed_Practical"
                    },
                    new QualifyingExamDetails
                    {
                        Id = 13,
                        Name = "B.EI.Ed. Practical",
                        CourseName = "M_Ed_Practical"
                    },
                    new QualifyingExamDetails
                    {
                        Id = 14,
                        Name = "D.EI.Ed. Practical",
                        CourseName = "M_Ed_Practical"
                    },
                    new QualifyingExamDetails
                    {
                        Id = 15,
                        Name = "B.A B.Ed. Practical",
                        CourseName = "M_Ed_Practical"
                    },
                    new QualifyingExamDetails
                    {
                        Id = 16,
                        Name = "B.Sc. B.Ed. Practical",
                        CourseName = "M_Ed_Practical"
                    }
                );
            #endregion

            modelBuilder.Entity<ExamCenter>().HasData(
                    new ExamCenter
                    {
                        Id = 1,
                        CenterName = "Almora"
                    },
                    new ExamCenter
                    {
                        Id = 2,
                        CenterName = "Bageshwar"
                    },
                    new ExamCenter
                    {
                        Id = 3,
                        CenterName = "Haldwani"
                    },
                    new ExamCenter
                    {
                        Id = 4,
                        CenterName = "Kashipur"
                    },
                    new ExamCenter
                    {
                        Id = 5,
                        CenterName = "Nainital"
                    },
                    new ExamCenter
                    {
                        Id = 6,
                        CenterName = "Pithoragarh"
                    },
                    new ExamCenter
                    {
                        Id = 7,
                        CenterName = "Ram Nagar"
                    },
                    new ExamCenter
                    {
                        Id = 8,
                        CenterName = "Rudrapur"
                    },
                    new ExamCenter
                    {
                        Id = 9,
                        CenterName = "Ranikhet"
                    },
                    new ExamCenter
                    {
                        Id = 10,
                        CenterName = "Khatima"
                    },
                    new ExamCenter
                    {
                        Id = 11,
                        CenterName = "Dwarahat"
                    },
                    new ExamCenter
                    {
                        Id = 12,
                        CenterName = "Lohaghat"
                    },
                    new ExamCenter
                    {
                        Id = 13,
                        CenterName = "Kichha"
                    },
                    new ExamCenter
                    {
                        Id = 14,
                        CenterName = "Berinag"
                    }
                );

            modelBuilder.Entity<Course>().HasData(
                new Course
                {
                    Id = "B.Ed",
                    CourseName = "Bachelor of Education"
                },
                new Course
                {
                    Id = "M.Ed",
                    CourseName = "Master of Education"
                }
            );
            modelBuilder.Entity<QualifyingType>().HasData(
                new QualifyingType
                {
                    Id = 1,
                    QualifyingTypeName = "Graduation"
                },
                new QualifyingType
                {
                    Id = 2,
                    QualifyingTypeName = "Post Graduation"
                },
                new QualifyingType
                {
                    Id = 3,
                    QualifyingTypeName = "Theory Exam"
                },
                new QualifyingType
                {
                    Id = 4,
                    QualifyingTypeName = "Practical Exam"
                }
            );
        }
    }
}
