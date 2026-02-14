import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { Observable, of } from 'rxjs';
import { AccountCard } from "../account-card/account-card";
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-account-panel',
  imports: [AccountCard, CommonModule],
  templateUrl: './account-panel.html',
  styleUrls: ['./account-panel.css'],
})
export class AccountPanel {
  accounts: Array<{ name: string; }> = [];

  constructor(private http: HttpClient) {}

  ngOnInit(): void {
    this.fetchAccounts().subscribe((data) => {
      this.accounts = data;
    });
  }
    mockData = [
      { name: 'Główne konto' },
      { name: 'Portfel BTC' },
      { name: 'Oszczędności' },
      { name: 'Karta Revolut' }
    ];
    
    fetchAccounts(): Observable<any> {
    return of(this.mockData)
    //return this.http.get('https://api.example.com/accounts');
  }
}
