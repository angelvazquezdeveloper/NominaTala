using DBLayer;
using System;
using System.Data;



class ConsultasImprimiblesl
    {
        ConsultasImprimibles Consultas = new ConsultasImprimibles();


    public DataSet RazonSocial(string type, string typeEmployed)
    {

        return Consultas.RazonSocial(type, typeEmployed);
    }

    public DataSet getListWeekRuldl(DateTime begin, DateTime end, string type)
    {

        return Consultas.getListWeekRuld(begin, end,type);
    }
    public DataSet getListEmployedl(string type)
    {

        return Consultas.getListEmployes(type);
    }
    public DataSet getListDatel(DateTime begin, DateTime end)
    {

        return Consultas.getListDate(begin, end);
    }
    public DataSet getTotalTreeByEmployedl(DateTime begin, DateTime end, string type)
    {

        return Consultas.getTotalTreeByEmployed(begin, end, type);
    }

    public DataSet getListForAttendancel(string type)
    {
        return Consultas.GetListForAttendance(type);
    }

}

