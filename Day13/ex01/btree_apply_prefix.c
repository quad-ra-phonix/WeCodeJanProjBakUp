/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   btree_apply_prefix.c                               :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: mmashego <marvin@42.fr>                    +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2016/02/18 15:05:50 by mmashego          #+#    #+#             */
/*   Updated: 2016/02/18 15:09:19 by mmashego         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "ft_btree.h"

void	btree_apply_prefix(t_btree *root, void (*applyf)(void *))
{
		if (!root)
		{
			(*applyf)(root->item);
			if (root->left)
					btree_applyf_prefix(root->left, applyf);
			if (root->right)
					btree_apply_prefix(root->right, applyf);
		}
}
