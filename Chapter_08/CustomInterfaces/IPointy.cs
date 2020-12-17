namespace CustomInterfaces
{
    public interface IPointy
    {
        // Implicitly public and abstract
        //byte GetNumberOfPoints();
        
        // A read-write property
        //string PropName { get; set; }
        
        // read-only property
        byte Points { get; }
        
    }
}