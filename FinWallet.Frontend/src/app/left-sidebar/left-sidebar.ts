import { Component, EventEmitter, Input, Output } from '@angular/core';
import { SidebarButton } from '../sidebar-button/sidebar-button';
import { AccountPanel } from '../account-panel/account-panel';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-left-sidebar',
  imports: [SidebarButton, AccountPanel, CommonModule],
  templateUrl: './left-sidebar.html',
  styleUrl: './left-sidebar.css',
})
export class LeftSidebar {
  @Input() currentActive: string = 'overview';
  @Output() panelChanged = new EventEmitter<string>();

  setActive(panel: string) {
    this.panelChanged.emit(panel);
  }
}
