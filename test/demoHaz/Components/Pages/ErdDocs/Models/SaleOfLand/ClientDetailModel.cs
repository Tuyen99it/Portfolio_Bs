using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

public class ClientDetailModel
{

    public string ClientName {get;set;}
    public string ClientNumber {get;set;}
    [Required] 
    public string ClientReference {get;set;}
    public string EnquiryId {get;set;}
}