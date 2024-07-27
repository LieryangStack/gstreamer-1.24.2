/* GStreamer
 *
 * Copyright (C) 2019 Collabora Ltd.
 *   Author: Stéphane Cerveau <scerveau@collabora.com>
 *
 * This library is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Library General Public
 * License as published by the Free Software Foundation; either
 * version 2.1 of the License, or (at your option) any later version.
 *
 * This library is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
 * Library General Public License for more details.
 *
 * You should have received a copy of the GNU Library General Public
 * License along with this library (COPYING); if not, write to the
 * Free Software Foundation, Inc., 59 Temple Place - Suite 330,
 * Boston, MA 02111-1307, USA.
 */
#ifndef __GSTMPDMETRICSNODE_H__
#define __GSTMPDMETRICSNODE_H__

#include <gst/gst.h>
#include "gstmpdhelper.h"

G_BEGIN_DECLS

#define GST_TYPE_MPD_METRICS_NODE gst_mpd_metrics_node_get_type ()
G_DECLARE_FINAL_TYPE (GstMPDMetricsNode2, gst_mpd_metrics_node, GST, MPD_METRICS_NODE, GstMPDNode)

typedef GstMPDMetricsNode2 GstMPDMetricsNode;
typedef GstMPDMetricsNode2Class GstMPDMetricsNodeClass;

struct _GstMPDMetricsNode2
{
  GstObject parent_instance;
  gchar *metrics;
  /* list of Metrics Range nodes */
  GList *MetricsRanges;
  /* list of Reporting nodes */
  GList *Reportings;
};

GstMPDMetricsNode * gst_mpd_metrics_node_new (void);
void gst_mpd_metrics_node_free (GstMPDMetricsNode* self);

G_END_DECLS

#endif /* __GSTMPDMETRICSNODE_H__ */
