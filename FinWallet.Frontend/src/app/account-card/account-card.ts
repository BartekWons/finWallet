import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-account-card',
  imports: [],
  templateUrl: './account-card.html',
  styleUrls: ['./account-card.css'],
})
export class AccountCard {
  @Input() account!: {name: string};
}
