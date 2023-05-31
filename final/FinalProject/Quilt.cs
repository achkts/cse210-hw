using System;
using System.Collections.Generic;

public abstract class Quilt{

    protected string _name;
    protected string _description;
    protected int _yearCreated;
    protected int _length;
    protected int _width;
    // protected int _howManyQuilts;
    // protected bool _handQuilted;
    // protected bool _machineQuilted;
    // protected string _machineQuiltedBy;
    protected Fabric _fabricUsed;
    

    public Quilt(string name, string description, int yearCreated, int length, int width, Fabric fabricUsed)
        {
            _name = name;
            _description = description;
            _yearCreated = yearCreated;
            _length = length;
            _width = width;
            _fabricUsed = fabricUsed;
            
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