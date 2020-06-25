﻿// Copyright (C) NeoAxis Group Ltd. 8 Copthall, Roseau Valley, 00152 Commonwealth of Dominica.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeoAxis.Editor;

namespace NeoAxis.Addon.EditorExample
{
	[AddToResourcesWindow( @"Addons\Addon creation\Editor Example Canvas" )]
	[EditorDocumentWindow( typeof( Component_EditorExampleCanvas_DocumentWindow ) )]
	public class Component_EditorExampleCanvas : Component
	{
		[Browsable( false )]
		[Serialize]
		public Vector2 EditorScrollPosition { get; set; }

		[Browsable( false )]
		[Serialize]
		public int EditorZoomIndex { get; set; } = 8;

		[DefaultValue( true )]
		public Reference<bool> DisplayCircle
		{
			get { if( _displayCircle.BeginGet() ) DisplayCircle = _displayCircle.Get( this ); return _displayCircle.value; }
			set { if( _displayCircle.BeginSet( ref value ) ) { try { DisplayCircleChanged?.Invoke( this ); } finally { _displayCircle.EndSet(); } } }
		}
		/// <summary>Occurs when the <see cref="DisplayCircle"/> property value changes.</summary>
		public event Action<Component_EditorExampleCanvas> DisplayCircleChanged;
		ReferenceField<bool> _displayCircle = true;
	}
}
