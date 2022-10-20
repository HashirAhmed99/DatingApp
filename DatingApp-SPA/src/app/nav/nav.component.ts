import { Component, OnInit } from '@angular/core';
import { PRIMARY_OUTLET } from '@angular/router';
import { AlertifyService } from '../_services/alertify.service';
import { AuthService } from '../_services/auth.service';
import { ErrorInterceptor } from '../_services/error.interceptor';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
  model:any = {};

  constructor(public authService: AuthService, private alertify: AlertifyService) { }

  ngOnInit(): void {
  }
  login(){
    this.authService.login(this.model).subscribe(next => {
      this.alertify.success('Logged in successfully');
    }, error =>{
      this.alertify.error("Error:" + error.response.body);
    });
  }
  
  loggedIn() {
    return this.authService.loggedIn();
  }
  logedOut (): void {
    localStorage.removeItem('token');
    this.alertify.message('logged out');
  }
}
