import { NgModule } from "@angular/core";
import { ButtonModule } from 'primeng/button';  
import { DataViewModule } from 'primeng/dataview';
import { TagModule } from 'primeng/tag';

@NgModule({
    imports: [ 
        ButtonModule,
        DataViewModule,
        TagModule


    ],
    exports: [
        ButtonModule,
        DataViewModule,
        TagModule
    ],
})
export class PrimengModule{}
