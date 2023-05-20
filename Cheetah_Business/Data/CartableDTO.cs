namespace Cheetah_Business.Data
{
    public class CartableDTO
    {
        CPersianClass cPersianClass = new CPersianClass();
        public String Username { get; set; }
        public String Requestor { get; set; }
        public String? RadNumber { get; set; }
        public DateTime? CreateDate { get; set; }
        public String? PCreateDate
        {
            get { return cPersianClass.GetPersianDate(CreateDate); }
        }
        public DateTime? RecieveDate { get; set; }
        public String? PRecieveDate
        {
            get { return cPersianClass.GetPersianDate(RecieveDate); }
        }
        public String? ProcessName { get; set; }
        public String? TaskName { get; set; }
        public string? Summary { get; set; }
        public CartableDTO()
        {

        }
        public CartableDTO(String username)
        {
            Username = username;
        }
    }
}