import { Component, OnInit } from '@angular/core';
import { EmployeeDetailService } from 'src/app/shared/employee-detail.service';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-employee-detail',
  templateUrl: './employee-detail.component.html',
  styles: [
  ]
})
export class EmployeeDetailComponent implements OnInit {

  constructor(private service:EmployeeDetailService) { }

  ngOnInit(): void {
    this.resetForm();
  }

  resetForm(form?:NgForm){
    if(form!=null)
      form.resetForm();
    this.service.formData = {
      ID : 0,
      Name : '',
      Address : '',
      Role : '',
      Department : '',
      SkillSets : '',
      DOB : '',
      DOJ : '',
      IsActive : false
    }
  }

  onSubmit(form:NgForm){
    this.service.postEmployeeDetail(form.value).subscribe(
      res => {
        this.resetForm(form);
      },
      err => {
        console.log(err);
      }
    )

  }

}
