//
//  PGoApiDelegate.swift
//  pgomap
//
//  Created by Luke Sapan on 7/20/16.
//  Copyright © 2016 Coadstal. All rights reserved.
//

import Foundation
import ProtocolBuffers


protocol PGoApiDelegate {
    func didReceiveApiResponse(_ intent: ApiIntent, response: ApiResponse)
    func didReceiveApiError(_ intent: ApiIntent, statusCode: Int?)
}
