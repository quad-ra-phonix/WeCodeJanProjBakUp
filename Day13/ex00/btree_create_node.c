/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   btree_create_node.c                                :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: mmashego <marvin@42.fr>                    +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2016/02/18 14:59:11 by mmashego          #+#    #+#             */
/*   Updated: 2016/02/18 15:01:52 by mmashego         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include <stdlib.h>
#include "ft_btree.h"

t_btree		*btree_create_node(void *item)
{
			t_btree		*btree;

			btree = NULL;
			btree = (t_btree*)malloc(sizeof(t_btree));
			if (btree)
			{
				btree->left = 0;
				btree->right = 0;
				btree->item = item;
			}
			return (btree);
}
