using System;
using System.Collections.Generic;

public class Fabric 
{
    private string fabricType;
    private string fabricDesigner;

public Fabric()
{

}
public Fabric(string _fabricType, string _fabricDesigner)
{
    fabricType = _fabricType;
    fabricDesigner = _fabricDesigner;
    

}

public string ToSummary()
{
    return $"{fabricType}, {fabricDesigner}";
}

public string ToFormat()
{
    return $"{fabricType}| {fabricDesigner}";
}
    


    
}