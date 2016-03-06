/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_btree.h                                         :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: mmashego <marvin@42.fr>                    +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2016/02/18 14:56:12 by mmashego          #+#    #+#             */
/*   Updated: 2016/02/18 15:03:32 by mmashego         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#ifndef __FT_BTREE_H__
#define __FT_BTREE_H__

typedef struct s_btree
{
		struct s_btree	*left;
		struct s_btree	*right;
		void			*item;
}			t_btree;

#endif
