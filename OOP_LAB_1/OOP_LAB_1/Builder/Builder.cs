namespace OOP_LAB_1.Builder
{
    public abstract class Builder
    {
        public abstract void AddManager();
        public abstract void AddJun();
        public abstract void AddSenior();
        public abstract void AddMiddle();
        public abstract ItCompany GetResult();
    }
}