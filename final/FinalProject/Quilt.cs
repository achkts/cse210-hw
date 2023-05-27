using System;
using System.Collections.Generic;

public abstract class Quilt{

    protected string _name;
    protected string _description;
    protected int _yearCreated;
    protected int _length;
    protected int _width;
    protected int _howManyQuilts;
    protected string _fabricsUsed;
    protected bool _handQuilted;
    protected bool _machineQuilted;
    protected string _machineQuiltedBy;
    
    public Quilt()
    {

    }


    public Quilt(string name, string description, int yearCreated, int length, int width)
        {
            name = _name;
            _description = description;
            _yearCreated = yearCreated;
            _length = length;
            _width = width;
            
        }

    

        public string GetName()
        {
            return _name;
        }

        public abstract string GetQuiltSummary();

        public abstract string GetQuiltFormat();

        public int GetArea()
        {
            return _length * _width;
        }

        
        



}