int estatusOperaciones = 5;

if (estatusOperaciones == (int)EstatusOperacion.Exitoso) 
{

    //....
}
else if (estatusOperaciones == (int)EstatusOperacion.ClienteNoEncontrado)
{
    //....
}
else if (estatusOperaciones == (int)EstatusOperacion.ErrorDeSistema)
{
    //...
}

public enum EstatusOperacion
{
    Exitoso =1,
    ClienteNoEncontrado= 2,
    ErrorDeSistema = 5,

}
