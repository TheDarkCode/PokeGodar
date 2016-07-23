//
//  DataExtensions.swift
//  PokeGodar
//
//  Created by Mark Hamilton on 7/23/16.
//  Copyright © 2016 dryverless. All rights reserved.
//

import Foundation

extension Data {
    
    public init?(count: Int) {
        
        self = Data(capacity: count)
        
    }
    
}
