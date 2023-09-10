using Cheetah_Business.Dimentions;
using System;

namespace Cheetah_Business.Data;

public class CartableDTO
{
    private CPersianClass? cPersianClass = new CPersianClass();

    public Int32? PageNumber { get; set; }
    public Int64? ERPCode { get; set; }
    public Int32? PageSize { get; set; }
    public Int32? TotalItems { get; set; }
    public SimpleClassDTO? Tag { get; set; }
    public SimpleClassDTO? User { get; set; }
    public SimpleClassDTO? Requestor { get; set; }
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
    public SimpleClassDTO? Process { get; set; }
    public SimpleClassDTO? Task { get; set; }
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