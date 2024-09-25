using System;
public class Pupil
{
    public virtual void Study()
    {
        Console.WriteLine("Pupil is studying");
    }

    public virtual void Read()
    {
        Console.WriteLine("Pupil is reading");
    }

    public virtual void Write()
    {
        Console.WriteLine("Pupil is writing");
    }

    public virtual void Relax()
    {
        Console.WriteLine("Pupil is relaxing");
    }
}
public class ExcelentPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("ExcelentPupil is studying very well");
    }

    public override void Read()
    {
        Console.WriteLine("ExcelentPupil is reading very well");
    }

    public override void Write()
    {
        Console.WriteLine("ExcelentPupil is writing very well");
    }

    public override void Relax()
    {
        Console.WriteLine("ExcelentPupil is relaxing a little");
    }
}
public class GoodPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("GoodPupil is studying well");
    }

    public override void Read()
    {
        Console.WriteLine("GoodPupil is reading well");
    }

    public override void Write()
    {
        Console.WriteLine("GoodPupil is writing well");
    }

    public override void Relax()
    {
        Console.WriteLine("GoodPupil is relaxing normally");
    }
}
public class BadPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("BadPupil is studying poorly");
    }

    public override void Read()
    {
        Console.WriteLine("BadPupil is reading poorly");
    }

    public override void Write()
    {
        Console.WriteLine("BadPupil is writing poorly");
    }

    public override void Relax()
    {
        Console.WriteLine("BadPupil is relaxing a lot");
    }
}
public class ClassRoom
{
    private Pupil[] pupils;

    public ClassRoom(params Pupil[] pupils)
    {
        if (pupils.Length < 4)
        {
            this.pupils = new Pupil[4];
            Array.Copy(pupils, this.pupils, pupils.Length);
            for (int i = pupils.Length; i < 4; i++)
            {
                this.pupils[i] = new Pupil(); 
            }
        }
        else
        {
            this.pupils = pupils;
        }
    }
    public void ShowPupilsActivities()
    {
        foreach (var pupil in pupils)
        {
            Console.WriteLine("--- Pupil Activities ---");
            pupil.Study();
            pupil.Read();
            pupil.Write();
            pupil.Relax();
            Console.WriteLine();
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Pupil excelentPupil = new ExcelentPupil();
        Pupil goodPupil = new GoodPupil();
        Pupil badPupil = new BadPupil();
        Pupil Pupil = new BadPupil();
        ClassRoom classRoom3 = new ClassRoom(excelentPupil, goodPupil, badPupil, Pupil);
        classRoom3.ShowPupilsActivities();
    }
}
