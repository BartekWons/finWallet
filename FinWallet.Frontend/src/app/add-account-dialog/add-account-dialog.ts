import { CommonModule } from '@angular/common';
import { Component, EventEmitter, Output } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-add-account-dialog',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './add-account-dialog.html',
  styleUrl: './add-account-dialog.css',
})

export class AddAccountDialog {
  accountName = '';
  selectedCurrency = '';
  parentAccount = '';
  isSubAccount = false;

  currencies: string[] = ['PLN', 'USD', 'EUR', 'GBP', 'BTC'];
  existingAccounts: any[] = [
    { name: 'Główne konto' },
    { name: 'Oszczędności' },
    { name: 'Portfel BTC' }
  ];

  @Output() close = new EventEmitter<void>();
  @Output() save = new EventEmitter<{ 
    name: string, 
    currency: string, 
    parentAccount?: string 
  }>();

  onSave() {
    if (this.accountName && this.selectedCurrency) {
      this.save.emit({
        name: this.accountName,
        currency: this.selectedCurrency,
        parentAccount: this.parentAccount
      });
      this.resetForm();
    }
  }

  onClose() {
    this.close.emit();
  }

  private resetForm() {
    this.accountName = '';
    this.selectedCurrency = '';
    this.parentAccount = '';
  }
}
