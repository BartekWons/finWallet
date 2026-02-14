import { Component, EventEmitter, Input, Output } from '@angular/core';

@Component({
  selector: 'app-sidebar-button',
  imports: [],
  templateUrl: './sidebar-button.html',
  styleUrl: './sidebar-button.css',
})
export class SidebarButton {
  @Input() label!: string;
  @Input() active = false;

  @Output() clicked = new EventEmitter<void>();

  onClick() {
    this.clicked.emit();
  }
}
