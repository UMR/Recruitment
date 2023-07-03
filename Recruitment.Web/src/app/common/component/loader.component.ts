﻿import { Component, Input } from '@angular/core';

@Component({
    selector: 'loading',
    template: `
<div class="center-body" id="loading" [ngClass]="{loaderDisplayBlock: isLoading, loaderDisplayNone: !isLoading}">
<div class="loader-circle-75"></div>
</div>
`,
    styles: [`
                .loaderDisplayBlock{
                     visibility: visible;
                }
                .loaderDisplayNone{
                    visibility: hidden;
                }
                .center-body {
					display: flex;
					justify-content: center;
					align-items: center;
					width: 100%;
					/****** center box
					width: 300px;
					height: 300px;
					border: solid 1px #aaa;
					******/
				}
				body {
					background-color: #111;
				}
				.loader-circle-75 {
					position: relative;
					width: 70px;
					height: 70px;
					display: inline-block;
				}
				.loader-circle-75:before {
					content: '';
					position: absolute;
					width: 100%;
					height: 100%;
					border-width: 3px 3px;
					border-style: solid;
					border-color: #ddbb00 rgba(221, 187, 0, 0.3);
					border-radius: 50%;
					box-sizing: border-box;
					animation: loader-circle-75-spin 3s infinite;
				}
				.loader-circle-75:after {
					content: '';
					position: absolute;
					width: 20px;
					height: 20px;
					top: 50%;
					left: 50%;
					background-color: #ffd700;
					border-radius: 50%;
					box-sizing: border-box;
					animation: loader-circle-75-pulse 6s infinite, loader-circle-75-borderPulse 6s infinite;
					transform: translate(-50%, -50%);
				}
				@keyframes loader-circle-75-spin {
					0% {
						transform: rotate(0deg);
					}
					50% {
						transform: rotate(360deg);
					}
					100% {
						transform: rotate(1080deg);
					}
				}
				@keyframes loader-circle-75-pulse {
					0% {
						background-color: rgba(221, 187, 0, 0.2);
					}
					13% {
						background-color: rgba(221, 187, 0, 0.2);
					}
					15% {
						background-color: rgba(255, 234, 119, 0.9);
					}
					28% {
						background-color: rgba(255, 234, 119, 0.9);
					}
					30% {
						background-color: rgba(221, 187, 0, 0.2);
					}
					43% {
						background-color: rgba(221, 187, 0, 0.2);
					}
					45% {
						background-color: rgba(255, 234, 119, 0.9);
					}
					70% {
						background-color: rgba(255, 234, 119, 0.9);
					}
					74% {
						background-color: rgba(221, 187, 0, 0.2);
					}
					100% {
						background-color: rgba(255, 234, 119, 0.9);
					}
				}
				@keyframes loader-circle-75-borderPulse {
					0% {
						box-shadow: 0 0 0 0 #FFF, 0 0 0 1px rgba(221, 187, 0, 0.8);
					}
					40% {
						box-shadow: 0 0 0 1px #FFF, 0 0 0 2px rgba(221, 187, 0, 0.8);
					}
					80% {
						box-shadow: 0 0 0 3px #FFF, 0 0 1px 3px rgba(221, 187, 0, 0.8);
					}
				}
				 `]
})

export class LoaderComponent {
    @Input('is-loading') isLoading: boolean = false;
}
