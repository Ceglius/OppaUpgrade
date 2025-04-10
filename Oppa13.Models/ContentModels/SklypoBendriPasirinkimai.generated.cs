//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v13.7.2+fd5b8de
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Cms.Core;
using Umbraco.Extensions;

namespace Oppa13.ContentModels
{
	// Mixin Content Type with alias "sklypoBendriPasirinkimai"
	/// <summary>Sklypo bendri pasirinkimai</summary>
	public partial interface ISklypoBendriPasirinkimai : IPublishedContent
	{
		/// <summary>Matavimo tipas</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string MatavimaiTipas { get; }

		/// <summary>Paskirtis</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string Paskirtis { get; }

		/// <summary>Plotas (a)</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		decimal PlotasA { get; }
	}

	/// <summary>Sklypo bendri pasirinkimai</summary>
	[PublishedModel("sklypoBendriPasirinkimai")]
	public partial class SklypoBendriPasirinkimai : PublishedContentModel, ISklypoBendriPasirinkimai
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		public new const string ModelTypeAlias = "sklypoBendriPasirinkimai";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<SklypoBendriPasirinkimai, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public SklypoBendriPasirinkimai(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Matavimo tipas
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("matavimaiTipas")]
		public virtual string MatavimaiTipas => GetMatavimaiTipas(this, _publishedValueFallback);

		/// <summary>Static getter for Matavimo tipas</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetMatavimaiTipas(ISklypoBendriPasirinkimai that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "matavimaiTipas");

		///<summary>
		/// Paskirtis
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("paskirtis")]
		public virtual string Paskirtis => GetPaskirtis(this, _publishedValueFallback);

		/// <summary>Static getter for Paskirtis</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetPaskirtis(ISklypoBendriPasirinkimai that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "paskirtis");

		///<summary>
		/// Plotas (a)
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		[ImplementPropertyType("plotasA")]
		public virtual decimal PlotasA => GetPlotasA(this, _publishedValueFallback);

		/// <summary>Static getter for Plotas (a)</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		public static decimal GetPlotasA(ISklypoBendriPasirinkimai that, IPublishedValueFallback publishedValueFallback) => that.Value<decimal>(publishedValueFallback, "plotasA");
	}
}
