import { HttpStatusCode } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { NgxSpinnerService } from "ngx-spinner";
import { handleHttpError } from 'src/app/common/helper';
import { RequestModel } from 'src/app/models/request.model';
import { RequestService } from 'src/app/services/request.service';

@Component({
    selector: 'app-create-request-form',
    templateUrl: 'create-request-form.component.html'
})
export class CreateRequestFormComponent implements OnInit {
    constructor(private loadingService: NgxSpinnerService,
                private requestService: RequestService) {}

    form?: FormGroup;

    ngOnInit(): void {
        this.form = new FormGroup({
            name: new FormControl('', [Validators.required, Validators.maxLength(100)]),
            email: new FormControl('', [Validators.required, Validators.maxLength(100), Validators.email]),
            description: new FormControl('', [Validators.required])
        })
    }

    onCreateRequest() {
        try {
            if (this.form?.valid) {
                this.loadingService.show();

                let model: RequestModel = {
                    Name: this.form.controls["name"].value,
                    Email: this.form.controls["email"].value,
                    Description: this.form.controls["description"].value
                };

                this.requestService.OnCreateRequest(model)
                    .subscribe(
                        {
                            next: res => {
                                this.loadingService.hide();
                                if (res) {
                                    this.form?.reset();
                                    console.log("Create request success.");
                                }
                            },
                            error: err => {
                                this.loadingService.hide();
                                handleHttpError(err);
                            }
                        }
                    )
            }
        } catch (err) {
            this.loadingService.hide();
            console.log(err);
        }
    }
}