using Cheetah_Business.Dimentions;
using System;

namespace Cheetah_Business.Data;

public class CartableDTO
{
    private CPersianClass? cPersianClass = new CPersianClass();

    public Int32? PageNumber { get; set; }
    public Int32? PageSize { get; set; }
    public Int32? TotalItems { get; set; }
    public virtual D_Tag? Tag { get; set; }
    public String? Username { get; set; }
    public String? Requestor { get; set; }
    public String? RadNumber { get; set; }
    public String? WorkItemId { get; set; }
    public DateTime? CreateDate { get; set; }
    public String? PCreateDate
    {
        get { return cPersianClass.GetPersianDate(this.CreateDate); }
        set { PCreateDate = value; }
    }
    public DateTime? RecieveDate { get; set; }
    public String? PRecieveDate
    {
        get { return cPersianClass.GetPersianDate(this.RecieveDate); }
        set { PRecieveDate = value; }
    }
    public String? ProcessName { get; set; }
    public String? TaskName { get; set; }
    public string? Summary { get; set; }
    public IEnumerable<SimpleClassDTO> ValidUserActions { get; set; }
    public SimpleClassDTO? CaseState { get; set; }

    //public CartableDTO()
    //{

    //}
    //public CartableDTO(String username)
    //{
    //    Username = username;
    //}
}