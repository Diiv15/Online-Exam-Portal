
//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Online_Exam_Project_Main.Models
{

using System;
    using System.Collections.Generic;
    
public partial class Subject_tbl
{

    public Subject_tbl()
    {

        this.Exam_tbl = new HashSet<Exam_tbl>();

    }


    public int subject_id { get; set; }

    public string subject_title { get; set; }

    public string subject_code { get; set; }



    public virtual ICollection<Exam_tbl> Exam_tbl { get; set; }

}

}
