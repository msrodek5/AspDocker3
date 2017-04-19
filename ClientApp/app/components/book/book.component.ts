import { Component } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'book',
    templateUrl: './book.component.html'
})
export class BookComponent {
    public books: Book[];

    constructor(http: Http) {
        http.get('/api/book').subscribe(result => {
            this.books = result.json() as Book[];
        });
    }
}

interface Book {
    id: number;
    title: string;
}
