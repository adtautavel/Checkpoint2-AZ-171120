namespace Checkpoint2_AZ_171120_DAL
{
    internal class Student
    {
        public int StudentId { get; set; }
        public string StudentFirstName { get; set; }
        public string StudentLastName { get; set; }
        public int FK_PromotionId { get; set; }
        public override string ToString()
        {
            return StudentFirstName + "-" + StudentLastName + ":\n" + "ID = " + StudentId + " ; " + "Promotion = " + FK_PromotionId + "\n";
        }
    }
}