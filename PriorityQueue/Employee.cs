 ﻿using System;
using System.Collections.Generic;
public class Employee : IComparable<Employee>
  {
    public string lastName;
    public double priority; // smaller values are higher priority

    public Employee(string lastName, double priority)
    {
      this.lastName = lastName;
      this.priority = priority;
    }

    public override string ToString()
    {
      return "(" + lastName + ", " + priority.ToString("F1") + ")";
    }

    public int CompareTo(Employee other)
    {
      if (this.priority < other.priority) return -1;
      else if (this.priority > other.priority) return 1;
      else return 0;
    }
  } // Employee