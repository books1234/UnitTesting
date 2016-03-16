namespace ProgrammeerOpdrachten
{
    public class Opdracht1
    {
        public bool KanIkUitslapen(bool IsWerkdag, bool IsVakantie)
        {
            return IsVakantie || !IsWerkdag;
        }
    }
}
