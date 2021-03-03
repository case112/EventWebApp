protected void Application_BeginRequest()
{
    CultureInfo cInf = new CultureInfo("et-EE", false);  
    // NOTE: change the culture name to whatever culture suits your needs

    cInf.DateTimeFormat.DateSeparator = "/";
    cInf.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";
    cInf.DateTimeFormat.LongDatePattern = "dd/MM/yyyy hh:mm:ss tt";

    System.Threading.Thread.CurrentThread.CurrentCulture = cInf;
    System.Threading.Thread.CurrentThread.CurrentUICulture = cInf;
}