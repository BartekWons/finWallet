import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";

@Injectable({
    providedIn: 'root'
})

export class ApiService{
    private api = 'http://localhost:7700/api'

    constructor(private http: HttpClient) {}
}


