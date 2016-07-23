//
//  Pokemon.swift
//  PokeGodar
//
//  Created by Mark Hamilton on 3/12/16.
//  Copyright © 2016 dryverless. All rights reserved.
//

import Foundation

final class Pokemon: NSObject {
    
    // Properties from CSV
    private var _id: Int! // pokedex id
    private var _name: String! // identifier
    private var _speciesId: Int? // species_id
    private var _height: String? // height
    private var _weight: String? // weight
    private var _baseExperience: Int? // base_experience
    private var _order: Int? // order
    private var _isDefault: Int? // is_default
    
    // Additional Properties from API
    private var _description: String!
    private var _type: String!
    private var _defense: Int!
    private var _attack: Int!
    
    private var _nextEvolutionId: String!
    private var _nextEvolutionLevel: String!
    private var _nextEvolution: String!
    
    private var _pokemonUrl: String!
    
    var id: Int {
        
        get {
            
            return _id
            
        }
        
    }
    
    var name: String {
        
        get {
            
            return _name
            
        }
        
    }
    
    var speciesId: Int {
        
        get {
            
            if let species: Int = _speciesId ?? Int() {
                
                return species
                
            }
            
        }
        
    }
    
    var height: String {
        
        get {
            
            if let howTall: String = _height ?? String() {
                
                return howTall
                
            }
            
        }
        
    }
    
    var weight: String {
        
        get {
            
            if let howHeavy: String = _weight ?? String() {
                
                return howHeavy
                
            }
            
        }
        
    }
    
    
    var baseExperience: Int {
        
        get {
            
            if let baseXp: Int = _baseExperience ?? Int() {
                
                return baseXp
                
            }
            
        }
        
    }
    
    var order: Int {
        
        get {
            
            if let odr: Int = _order ?? Int() {
                
                return odr
                
            }
            
        }
        
    }
    
    var isDefault: Int {
        
        get {
            
            if let isdefault: Int = _isDefault ?? Int() {
                
                return isdefault
                
            }
            
        }
        
    }
    
    
    var desc: String {
        
        get {
            
            if let descript: String = _description ?? String() {
                
                return descript
                
            }
            
        }
        
        //        set {
        //
        //            _description = newValue
        //        }
        
    }
    
    var type: String {
        
        get {
            
            if let ty: String = _type ?? String() {
                
                return ty
                
            }
            
        }
        
        //        set {
        //
        //            _type = newValue
        //        }
        
    }
    
    var defense: Int {
        
        get {
            
            if let def: Int = _defense ?? Int() {
                
                return def
                
            }
            
        }
        
        //        set {
        //
        //            _defense = newValue
        //        }
        
    }
    
    var attack: Int {
        
        get {
            
            if let atk: Int = _attack ?? Int() {
                
                return atk
                
            }
            
        }
        
        //        set {
        //
        //            _attack = newValue
        //        }
        
    }
    
    var nextEvolution: String {
        
        get {
            
            if let nextEvo: String = _nextEvolution ?? String() {
                
                return nextEvo
                
            }
            
        }
        
        //        set {
        //
        //            _defense = newValue
        //        }
        
    }
    
    var nextEvolutionId: String {
        
        get {
            
            if let nextEvoId: String = _nextEvolutionId ?? String() {
                
                return nextEvoId
                
            }
            
        }
        
    }
    
    var nextEvolutionLevel: String {
        
        get {
            
            if let nextEvoLvl: String = _nextEvolutionLevel ?? String() {
                
                return nextEvoLvl
                
            }
            
        }
        
    }
    
    convenience init(id: Int, name: String, species: Int, height: String, weight: String, baseXp: Int, order: Int, isDefault: Int) {
        
        self.init(id: id, name: name)
        
        self._speciesId = species
        self._height = height
        self._weight = weight
        self._baseExperience = baseXp
        self._order = order
        self._isDefault = isDefault
        
    }
    
    init(id: Int, name: String) {
        
        self._id = id
        self._name = name
        
        _pokemonUrl = "\(API_BASE)\(self._id)/"
        
    }
    
}
