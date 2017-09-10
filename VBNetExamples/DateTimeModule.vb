Module DateTimeModule

    'DateAndTime helper class 
    Public Sub Example3()
        Dim d As DateTime = #2010/10/10 10:10:10#
        Dim d2 As DateTime = DateAndTime.Today
        Dim d3 As DateTime = DateAndTime.Now
        Dim d4 As DateTime = DateAndTime.TimeOfDay

        Dim year As Integer = DateAndTime.Year(d)
        Dim month As Integer = DateAndTime.Month(d)
        Dim day As Integer = DateAndTime.Day(d)
        Dim weekDay As Integer = DateAndTime.Weekday(d)
        Dim weekDayName As String = DateAndTime.WeekdayName(weekDay)
        Dim hour As Integer = DateAndTime.Hour(d)
        Dim minute As Integer = DateAndTime.Minute(d)
        Dim second As Integer = DateAndTime.Second(d)
        Console.WriteLine("year = " & year)
        Console.WriteLine("month = " & month)
        Console.WriteLine("day = " & day)
        Console.WriteLine("weekDay = " & weekDay)
        Console.WriteLine("weekDayName = " & weekDayName)
        Console.WriteLine("hour = " & hour)
        Console.WriteLine("minute = " & minute)
        Console.WriteLine("second = " & second)
        Console.WriteLine()

        d = DateAndTime.DateAdd(DateInterval.Year, 1, d)
        d = DateAndTime.DateAdd(DateInterval.Month, 1, d)
        d = DateAndTime.DateAdd(DateInterval.Day, 1, d)
        d = DateAndTime.DateAdd(DateInterval.Hour, 1, d)
        d = DateAndTime.DateAdd(DateInterval.Minute, 1, d)
        d = DateAndTime.DateAdd(DateInterval.Second, 1, d)

        year = DateAndTime.Year(d)
        month = DateAndTime.Month(d)
        day = DateAndTime.Day(d)
        weekDay = DateAndTime.Weekday(d)
        weekDayName = DateAndTime.WeekdayName(weekDay)
        hour = DateAndTime.Hour(d)
        minute = DateAndTime.Minute(d)
        second = DateAndTime.Second(d)

        Console.WriteLine("year = " & year)
        Console.WriteLine("month = " & month)
        Console.WriteLine("day = " & day)
        Console.WriteLine("weekDay = " & weekDay)
        Console.WriteLine("weekDayName = " & weekDayName)
        Console.WriteLine("hour = " & hour)
        Console.WriteLine("minute = " & minute)
        Console.WriteLine("second = " & second)
        Console.WriteLine()


        d2 = New DateTime(2010, 10, 10, 10, 10, 10)
        d3 = New DateTime(2012, 10, 10, 10, 10, 10)
        Dim interval As Long = DateAndTime.DateDiff(DateInterval.Year, d2, d3)
        Console.WriteLine("year interval = " & interval)
        interval = DateAndTime.DateDiff(DateInterval.Month, d2, d3)
        Console.WriteLine("month interval = " & interval)
        interval = DateAndTime.DateDiff(DateInterval.Day, d2, d3)
        Console.WriteLine("daya interval = " & interval)
        Console.WriteLine()

        year = DateAndTime.DatePart(DateInterval.Year, d)
        month = DateAndTime.DatePart(DateInterval.Month, d)
        day = DateAndTime.DatePart(DateInterval.Day, d)
        hour = DateAndTime.DatePart(DateInterval.Hour, d)
        minute = DateAndTime.DatePart(DateInterval.Minute, d)
        second = DateAndTime.DatePart(DateInterval.Second, d)
        weekDay = DateAndTime.DatePart(DateInterval.Weekday, d)


        Console.WriteLine("year = " & year)
        Console.WriteLine("month = " & month)
        Console.WriteLine("day = " & day)
        Console.WriteLine("weekDay = " & weekDay)
        Console.WriteLine("weekDayName = " & weekDayName)
        Console.WriteLine("hour = " & hour)
        Console.WriteLine("minute = " & minute)
        Console.WriteLine("second = " & second)
        Console.WriteLine()

        d = DateAndTime.DateSerial(2010, 10, 10)

    End Sub


    'Formatting DateTime
    Public Sub Example2()
        'G, D, d, T, t, f, F, g, M, m , R , r, s, u, U, Y, y
        Dim d As DateTime = #2010/10/10 10:10:10#
        Console.WriteLine("G = " & d.ToString("G"))
        Console.WriteLine("D = " & d.ToString("D"))
        Console.WriteLine("d = " & d.ToString("d"))
        Console.WriteLine("T = " & d.ToString("T"))
        Console.WriteLine("t = " & d.ToString("t"))
        Console.WriteLine("f = " & d.ToString("f"))
        Console.WriteLine("F = " & d.ToString("F"))
        Console.WriteLine("g = " & d.ToString("g"))
        Console.WriteLine("M = " & d.ToString("M"))
        Console.WriteLine("m = " & d.ToString("m"))
        Console.WriteLine("R = " & d.ToString("R"))
        Console.WriteLine("r = " & d.ToString("r"))
        Console.WriteLine("s = " & d.ToString("s"))
        Console.WriteLine("u = " & d.ToString("u"))
        Console.WriteLine("U = " & d.ToString("U"))
        Console.WriteLine("y = " & d.ToString("y"))
        Console.WriteLine("Y = " & d.ToString("Y"))
        Console.WriteLine()
    End Sub

    'DateTime structure 
    Public Sub Example1()
        Dim d1 As DateTime = New DateTime(2010, 10, 10, 10, 10, 10)
        Dim d2 As DateTime = DateTime.Today
        Dim d3 As DateTime = DateTime.Now
        Dim d4 As DateTime = DateTime.UtcNow
        Dim d5 As DateTime = #10/10/2010 10:10:10 AM#

        Dim year As Integer = d1.Year
        Dim month As Integer = d1.Month
        Dim day As Integer = d1.Day
        Dim dayOfYear As Integer = d1.DayOfYear
        Dim dayOfWeek As Integer = d1.DayOfWeek
        Dim hour As Integer = d1.Hour
        Dim minute As Integer = d1.Minute
        Dim second As Integer = d1.Second
        Dim ms As Integer = d1.Millisecond
        Dim dt As Date = d1.Date
        Dim ts As TimeSpan = d1.TimeOfDay

        Console.WriteLine("year = " & year)
        Console.WriteLine("month = " & month)
        Console.WriteLine("day = " & day)
        Console.WriteLine("hour = " & hour)
        Console.WriteLine("minute = " & minute)
        Console.WriteLine("second = " & second)
        Console.WriteLine("ms  = " & ms)
        Console.WriteLine("dt = " & dt.ToString())
        Console.WriteLine("ts = " & ts.ToString())
        Console.WriteLine()

        d1 = d1.AddYears(1)
        d1 = d1.AddMonths(1)
        d1 = d1.AddDays(1)
        d1 = d1.AddHours(1)
        d1 = d1.AddMinutes(1)
        d1 = d1.AddSeconds(1)
        d1 = d1.AddMilliseconds(1)

        year = d1.Year
        month = d1.Month
        day = d1.Day
        dayOfYear = d1.DayOfYear
        dayOfWeek = d1.DayOfWeek
        hour = d1.Hour
        minute = d1.Minute
        second = d1.Second
        ms = d1.Millisecond
        dt = d1.Date
        ts = d1.TimeOfDay

        Console.WriteLine("year = " & year)
        Console.WriteLine("month = " & month)
        Console.WriteLine("day = " & day)
        Console.WriteLine("dayOfYear = " & dayOfYear)
        Console.WriteLine("dayOfWeek = " & dayOfWeek)
        Console.WriteLine("hour = " & hour)
        Console.WriteLine("minute = " & minute)
        Console.WriteLine("second = " & second)
        Console.WriteLine("ms = " & ms)
        Console.WriteLine("dt = " & dt)
        Console.WriteLine("ts = " & ts.ToString())
        Console.WriteLine()

        d1 = d1.Add(New TimeSpan(1, 1, 1, 1))
        year = d1.Year
        month = d1.Month
        day = d1.Day
        dayOfYear = d1.DayOfYear
        dayOfWeek = d1.DayOfWeek
        hour = d1.Hour
        minute = d1.Minute
        second = d1.Second
        ms = d1.Millisecond
        dt = d1.Date
        ts = d1.TimeOfDay

        Console.WriteLine("year = " & year)
        Console.WriteLine("month = " & month)
        Console.WriteLine("day = " & day)
        Console.WriteLine("dayOfYear = " & dayOfYear)
        Console.WriteLine("dayOfWeek = " & dayOfWeek)
        Console.WriteLine("hour = " & hour)
        Console.WriteLine("minute = " & minute)
        Console.WriteLine("second = " & second)
        Console.WriteLine("ms = " & ms)
        Console.WriteLine("dt = " & dt)
        Console.WriteLine("ts = " & ts.ToString())
        Console.WriteLine()

    End Sub
End Module
