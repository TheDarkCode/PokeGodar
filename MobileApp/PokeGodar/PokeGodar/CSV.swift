//
//  CSV.swift
//  PokeGodar
//
//  Created by Mark Hamilton on 3/12/16.
//  Copyright © 2016 dryverless. All rights reserved.
//

import Foundation

final public class CSV {
    
    public var headers: [String] = []
    public var rows: [Dictionary<String, String>] = []
    public var columns = Dictionary<String, [String]>()
    var delimiter = CharacterSet(charactersIn: ",")
    
    public init(content: String?, delimiter: CharacterSet, encoding: UInt) throws{
        
        if let csvStringToParse = content{
            
            self.delimiter = delimiter
            
            let newline = CharacterSet.newlines
            var lines: [String] = []
            csvStringToParse.trimmingCharacters(in: newline).enumerateLines { line, stop in lines.append(line) }
            
            self.headers = self.parseHeaders(fromLines: lines)
            self.rows = self.parseRows(fromLines: lines)
            self.columns = self.parseColumns(fromLines: lines)
            
        }
        
    }
    
    public convenience init(contentsOfURL url: String) throws {
        
        let comma = CharacterSet(charactersIn: ",")
        let csvString: String?
        
        do {
            
            csvString = try String(contentsOfFile: url, encoding: String.Encoding.utf8)
            
        } catch _ {
            
            csvString = nil
            
        };
        
        try self.init(content: csvString,delimiter:comma, encoding:String.Encoding.utf8.rawValue)
        
    }
    
    
    func parseHeaders(fromLines lines: [String]) -> [String] {
        
        return lines[0].components(separatedBy: self.delimiter)
        
    }
    
    func parseRows(fromLines lines: [String]) -> [Dictionary<String, String>] {
        
        var rows: [Dictionary<String, String>] = []
        
        for (lineNumber, line) in lines.enumerated() {
            
            if lineNumber == 0 {
                continue
            }
            
            var row = Dictionary<String, String>()
            let values = line.components(separatedBy: self.delimiter)
            
            for (index, header) in self.headers.enumerated() {
                
                if index < values.count {
                    
                    row[header] = values[index]
                    
                } else {
                    
                    row[header] = ""
                    
                }
                
            }
            
            rows.append(row)
            
        }
        
        return rows
        
    }
    
    func parseColumns(fromLines lines: [String]) -> Dictionary<String, [String]> {
        
        var columns = Dictionary<String, [String]>()
        
        for header in self.headers {
            
            let column = self.rows.map { row in row[header] != nil ? row[header]! : "" }
            
            columns[header] = column
            
        }
        
        return columns
        
    }
    
}
