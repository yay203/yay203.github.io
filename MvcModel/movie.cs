using System;
using System.ComponentModel.DataAnnotations;
namespace MvcModel
{
public class movieData
{
private int m_Id;
private string m_mname;
private string m_mpic;
private string m_mtype;
private string m_mmtime;
private string m_mpress;
private string m_mscore;
private string m_maddress;
private string m_mting;
private string m_mbrand;
private string m_mcc;
private string m_mprice;
private string m_status;
private string m_turnurl;

public int Id
{
get { return this.m_Id; }
set { this.m_Id = value; }
}
[DisplayFormat(ConvertEmptyStringToNull = false)]
public string mname
{
get { return this.m_mname ;}
set { this.m_mname = value; }
}
[DisplayFormat(ConvertEmptyStringToNull = false)]
public string mpic
{
get { return this.m_mpic ;}
set { this.m_mpic = value; }
}
[DisplayFormat(ConvertEmptyStringToNull = false)]
public string mtype
{
get { return this.m_mtype ;}
set { this.m_mtype = value; }
}
[DisplayFormat(ConvertEmptyStringToNull = false)]
public string mmtime
{
get { return this.m_mmtime ;}
set { this.m_mmtime = value; }
}
[DisplayFormat(ConvertEmptyStringToNull = false)]
public string mpress
{
get { return this.m_mpress ;}
set { this.m_mpress = value; }
}
[DisplayFormat(ConvertEmptyStringToNull = false)]
public string mscore
{
get { return this.m_mscore ;}
set { this.m_mscore = value; }
}
[DisplayFormat(ConvertEmptyStringToNull = false)]
public string maddress
{
get { return this.m_maddress ;}
set { this.m_maddress = value; }
}
[DisplayFormat(ConvertEmptyStringToNull = false)]
public string mting
{
get { return this.m_mting ;}
set { this.m_mting = value; }
}
[DisplayFormat(ConvertEmptyStringToNull = false)]
public string mbrand
{
get { return this.m_mbrand ;}
set { this.m_mbrand = value; }
}
[DisplayFormat(ConvertEmptyStringToNull = false)]
public string mcc
{
get { return this.m_mcc ;}
set { this.m_mcc = value; }
}
[DisplayFormat(ConvertEmptyStringToNull = false)]
public string mprice
{
get { return this.m_mprice ;}
set { this.m_mprice = value; }
}
[DisplayFormat(ConvertEmptyStringToNull = false)]
public string status
{
get { return this.m_status ;}
set { this.m_status = value; }
}
[DisplayFormat(ConvertEmptyStringToNull = false)]
public string turnurl
{
get { return this.m_turnurl ;}
set { this.m_turnurl = value; }
}
}}
