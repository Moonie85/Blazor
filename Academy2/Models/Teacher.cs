using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Academy2.Models
{
    public class Teacher
    {
        [Key]
        [Column(TypeName ="SMALLINT")]
        public int teacher_id { get; set; }
        public DateOnly work_since {  get; set; }
        
        [Column(TypeName = "SMALLMONEY")]
        public int rate { get; set; }

        public ICollection<Discipline> Disciplines { get; set; }
        public ICollection<TeachersDisciplinesRelation>? TDR { get; set; }

    }
}
