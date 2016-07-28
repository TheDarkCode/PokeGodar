//
//  Example.swift
//  pgoapi
//
//  Created by Luke Sapan on 7/21/16.
//  Copyright © 2016 Coadstal. All rights reserved.
//

import UIKit

class ExampleViewController: UIViewController, AuthDelegate, PGoApiDelegate {
    
    override func viewDidLoad() {
        super.viewDidLoad()
        
        Auth.sharedInstance.delegate = self
        Auth.sharedInstance.login("login", password: "password")
    }
    
    func didReceiveAuth() {
        print("Auth received!!")
        print("Starting simulation...")
        let request = PGoApiRequest()
        request.simulateAppStart()
        request.makeRequest(.Login, delegate: self)
    }
    
    func didNotReceiveAuth() {
        print("Failed to auth!")
    }
    
    func didReceiveApiResponse(intent: ApiIntent, response: ApiResponse) {
        print("Got that API response: \(intent)")
        if (intent == .Login) {
            Api.endpoint = "https://\((response.response as! Pogoprotos.Networking.Envelopes.ResponseEnvelope).apiUrl)/rpc"
            print("New endpoint: \(Api.endpoint)")
            let request = PGoApiRequest()
            request.getMapObjects(0, longitude: 0)
            request.makeRequest(.GetMapObjects, delegate: self)
        } else if (intent == .GetMapObjects) {
            print("Got map objects!")
            print("---------\n---------")
            print(response.response)
            print(response.subresponses)
        }
    }
    
    func didReceiveApiError(intent: ApiIntent, statusCode: Int?) {
        print("API Error: \(statusCode)")
    }
    
}

