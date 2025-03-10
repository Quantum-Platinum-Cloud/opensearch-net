/* SPDX-License-Identifier: Apache-2.0
*
* The OpenSearch Contributors require contributions made to
* this file be licensed under the Apache-2.0 license or a
* compatible open source license.
*/
/*
* Modifications Copyright OpenSearch Contributors. See
* GitHub history for details.
*
*  Licensed to Elasticsearch B.V. under one or more contributor
*  license agreements. See the NOTICE file distributed with
*  this work for additional information regarding copyright
*  ownership. Elasticsearch B.V. licenses this file to you under
*  the Apache License, Version 2.0 (the "License"); you may
*  not use this file except in compliance with the License.
*  You may obtain a copy of the License at
*
* 	http://www.apache.org/licenses/LICENSE-2.0
*
*  Unless required by applicable law or agreed to in writing,
*  software distributed under the License is distributed on an
*  "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
*  KIND, either express or implied.  See the License for the
*  specific language governing permissions and limitations
*  under the License.
*/

// ReSharper disable RedundantUsingDirective
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using OpenSearch.Net;
using OpenSearch.Net.Utf8Json;
using OpenSearch.Net.Specification.DanglingIndicesApi;

// ReSharper disable RedundantBaseConstructorCall
// ReSharper disable UnusedTypeParameter
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
namespace OpenSearch.Client
{
	///<summary>Descriptor for DeleteDanglingIndex <para></para></summary>
	public partial class DeleteDanglingIndexDescriptor : RequestDescriptorBase<DeleteDanglingIndexDescriptor, DeleteDanglingIndexRequestParameters, IDeleteDanglingIndexRequest>, IDeleteDanglingIndexRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.DanglingIndicesDeleteDanglingIndex;
		///<summary>/_dangling/{index_uuid}</summary>
		///<param name = "indexUuid">this parameter is required</param>
		public DeleteDanglingIndexDescriptor(IndexUuid indexUuid): base(r => r.Required("index_uuid", indexUuid))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected DeleteDanglingIndexDescriptor(): base()
		{
		}

		// values part of the url path
		IndexUuid IDeleteDanglingIndexRequest.IndexUuid => Self.RouteValues.Get<IndexUuid>("index_uuid");
		// Request parameters
		///<summary>Must be set to true in order to delete the dangling index</summary>
		public DeleteDanglingIndexDescriptor AcceptDataLoss(bool? acceptdataloss = true) => Qs("accept_data_loss", acceptdataloss);
		///<summary>Explicit operation timeout for connection to master node</summary>
		///<remarks>Deprecated as of OpenSearch 2.0, use <see cref="ClusterManagerTimeout"/> instead</remarks>
		public DeleteDanglingIndexDescriptor MasterTimeout(Time mastertimeout) => Qs("master_timeout", mastertimeout);
		///<summary>Explicit operation timeout for connection to cluster_manager node</summary>
		///<remarks>Introduced in OpenSearch 2.0 instead of <see cref="MasterTimeout"/></remarks>
		public DeleteDanglingIndexDescriptor ClusterManagerTimeout(Time timeout) => Qs("cluster_manager_timeout", timeout);
		///<summary>Explicit operation timeout</summary>
		public DeleteDanglingIndexDescriptor Timeout(Time timeout) => Qs("timeout", timeout);
	}

	///<summary>Descriptor for ImportDanglingIndex <para></para></summary>
	public partial class ImportDanglingIndexDescriptor : RequestDescriptorBase<ImportDanglingIndexDescriptor, ImportDanglingIndexRequestParameters, IImportDanglingIndexRequest>, IImportDanglingIndexRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.DanglingIndicesImportDanglingIndex;
		///<summary>/_dangling/{index_uuid}</summary>
		///<param name = "indexUuid">this parameter is required</param>
		public ImportDanglingIndexDescriptor(IndexUuid indexUuid): base(r => r.Required("index_uuid", indexUuid))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected ImportDanglingIndexDescriptor(): base()
		{
		}

		// values part of the url path
		IndexUuid IImportDanglingIndexRequest.IndexUuid => Self.RouteValues.Get<IndexUuid>("index_uuid");
		// Request parameters
		///<summary>Must be set to true in order to import the dangling index</summary>
		public ImportDanglingIndexDescriptor AcceptDataLoss(bool? acceptdataloss = true) => Qs("accept_data_loss", acceptdataloss);
		///<summary>Explicit operation timeout for connection to master node</summary>
		///<remarks>Deprecated as of OpenSearch 2.0, use <see cref="ClusterManagerTimeout"/> instead</remarks>
		public ImportDanglingIndexDescriptor MasterTimeout(Time mastertimeout) => Qs("master_timeout", mastertimeout);
		///<summary>Explicit operation timeout for connection to cluster_manager node</summary>
		///<remarks>Introduced in OpenSearch 2.0 instead of <see cref="MasterTimeout"/></remarks>
		public ImportDanglingIndexDescriptor ClusterManagerTimeout(Time timeout) => Qs("cluster_manager_timeout", timeout);
		///<summary>Explicit operation timeout</summary>
		public ImportDanglingIndexDescriptor Timeout(Time timeout) => Qs("timeout", timeout);
	}

	///<summary>Descriptor for List <para></para></summary>
	public partial class ListDanglingIndicesDescriptor : RequestDescriptorBase<ListDanglingIndicesDescriptor, ListDanglingIndicesRequestParameters, IListDanglingIndicesRequest>, IListDanglingIndicesRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.DanglingIndicesList;
	// values part of the url path
	// Request parameters
	}
}
