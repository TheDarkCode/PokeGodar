//
//  Extensions.swift
//  pgomap
//
//  Created by Luke Sapan on 7/20/16.
//  Copyright © 2016 Coadstal. All rights reserved.
//

import Foundation

extension NSRange {
    func rangeForString(_ str: String) -> Range<String.Index>? {
        guard location != NSNotFound else { return nil }
        return str.characters.index(str.startIndex, offsetBy: location) ..< str.characters.index(str.startIndex, offsetBy: location + length)
    }
}
