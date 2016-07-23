//
//  Pogoprotos.swift
//  pgomap
//
//  Created by Luke Sapan on 7/20/16.
//  Copyright © 2016 Coadstal. All rights reserved.
//

import Foundation
import ProtocolBuffers


// TEMPORARY FIX UNTIL https://github.com/alexeyxo/protobuf-swift/issues/150 is fixed

public struct Pogoprotos {
    
    public struct Data {
        public struct Battle { }
        public struct Capture { }
        public struct Gym { }
        public struct Player { }
    }
    
    public struct Enums { }
    
    public struct Inventory { }
    
    public struct Map {
        public struct Fort { }
        public struct Pokemon { }
    }
    
    public struct Networking {
        public struct Envelopes { }
        public struct Requests {
            public struct Messages { }
        }
        public struct Responses { }
    }
    
    public struct Settings {
        public struct Master {
            public struct Item { }
            public struct Pokemon { }
        }
    }
    
}

protocol ResponseParser {
    static func parseFromData(_ data:Data) throws -> GeneratedMessage
}
