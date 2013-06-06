// ============================================================================================
//   .NET API for EJDB database library http://ejdb.org
//   Copyright (C) 2012-2013 Softmotions Ltd <info@softmotions.com>
//
//   This file is part of EJDB.
//   EJDB is free software; you can redistribute it and/or modify it under the terms of
//   the GNU Lesser General Public License as published by the Free Software Foundation; either
//   version 2.1 of the License or any later version.  EJDB is distributed in the hope
//   that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of
//   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU Lesser General Public
//   License for more details.
//   You should have received a copy of the GNU Lesser General Public License along with EJDB;
//   if not, write to the Free Software Foundation, Inc., 59 Temple Place, Suite 330,
//   Boston, MA 02111-1307 USA.
// ============================================================================================
using System;



namespace Ejdb.SON {

	/** <summary> BSON types according to the bsonspec (http://bsonspec.org/)</summary> */ 

	public enum BSONType : byte {
		UNKNOWN = 0xfe,
		EOO = 0,
		DOUBLE = 1,
		STRING = 2,
		OBJECT = 3,
		ARRAY = 4,
		BINDATA = 5,
		UNDEFINED = 6,
		OID = 7,
		BOOL = 8,
		DATE = 9,
		NULL = 10,
		REGEX = 11,
		DBREF = 12, /**< Deprecated. */
		CODE = 13,
		SYMBOL = 14,
		CODEWSCOPE = 15,
		INT = 16,
		TIMESTAMP = 17,
		LONG = 18	
	}
}

